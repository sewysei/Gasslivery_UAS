using Class_Gasslivery;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormRide : Form
    {
        FormUtama frmUtama;
        Voucher selectedVoucher;

        public FormRide(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void FormRide_Load(object sender, EventArgs e)
        {
            frmUtama = (FormUtama)this.MdiParent;
            
            dateTimePickerJadwalkan.MinDate = DateTime.Now;
            dateTimePickerJadwalkan.MaxDate = DateTime.Now.AddHours(24);
            dateTimePickerJadwalkan.Value = DateTime.Now.AddHours(1);
            dateTimePickerJadwalkan.Enabled = false;

            comboBox1.Items.Clear();
            List<Voucher> vocer = new List<Voucher>(Voucher.BacaData());
            comboBox1.DataSource = vocer;
            comboBox1.DisplayMember = "Name";
            selectedVoucher = comboBox1.SelectedItem as Voucher;

            if (frmUtama.consumerLogin?.Gender?.ToLower() != "female")
            {
                checkBoxDriverWanita.Enabled = false;
                checkBoxDriverWanita.Text = "Driver Wanita (Hanya untuk konsumen wanita)";
            }

            if (frmUtama.consumerLogin != null)
            {
                int maxPoin = frmUtama.consumerLogin.Point;
                numericUpDownPoin.Maximum = maxPoin;
                numericUpDownPoin.Minimum = 0;
                numericUpDownPoin.Increment = 5000;
                numericUpDownPoin.Value = 0;
                labelPoinTersedia.Text = $"Poin tersedia: {maxPoin:N0}";
            }
        }

        private void HitungJarakDanOngkos()
        {
            try
            {
                double latPickup = double.Parse(textBoxLatitudeJemput.Text.Trim());
                double lonPickup = double.Parse(textBoxLongitudeJemput.Text.Trim());
                double latDest = double.Parse(textBoxLatitudeTujuan.Text.Trim());
                double lonDest = double.Parse(textBoxLongitudeTujuan.Text.Trim());

                if (latPickup != 0 && lonPickup != 0 && latDest != 0 && lonDest != 0)
                {
                    double jarak = HitungJarak.HitungJarakKm(latPickup, lonPickup, latDest, lonDest);
                    
                    DateTime waktu = radioButtonSekarang.Checked ? DateTime.Now : dateTimePickerJadwalkan.Value;
                    int tarifPerKm = RideCalculator.GetHargaPerKm(waktu);
                    int baseFee = (int)(jarak * tarifPerKm);
                    
                    int tambahan = 0;
                    if (checkBoxDriverWanita.Checked) tambahan += 1500;
                    if (checkBoxMotorBaru.Checked) tambahan += 5000;
                    
                    int diskon = 0;
                    if (comboBox1.SelectedItem is Voucher voucher && !string.IsNullOrEmpty(voucher.Value))
                    {
                        diskon = int.Parse(voucher.Value);
                    }
                    
                    int poinDigunakan = (int)numericUpDownPoin.Value;
                    int total = baseFee + tambahan - diskon - poinDigunakan;

                    labelJarak.Text = jarak.ToString("0.00") + " KM";
                    labelOngkos.Text = $"Rp. {Math.Max(0, total)}";
        }
                else
                {
                    labelJarak.Text = "-";
                    labelOngkos.Text = "Rp0";
                }
            }
            catch
            {
                labelJarak.Text = "-";
                labelOngkos.Text = "Rp0";
            }
        }

        private void buttonPesanRide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitikJemput.Text) ||
                string.IsNullOrWhiteSpace(textBoxTitikTujuan.Text) ||
                string.IsNullOrWhiteSpace(textBoxLatitudeJemput.Text) ||
                string.IsNullOrWhiteSpace(textBoxLongitudeJemput.Text) ||
                string.IsNullOrWhiteSpace(textBoxLatitudeTujuan.Text) ||
                string.IsNullOrWhiteSpace(textBoxLongitudeTujuan.Text))
            {
                MessageBox.Show("Mohon lengkapi semua field yang diperlukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (labelJarak.Text == "-" || string.IsNullOrEmpty(labelJarak.Text))
            {
                MessageBox.Show("Mohon pastikan koordinat sudah benar untuk menghitung jarak!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButtonSekarang.Checked)
            {
                DateTime waktu = dateTimePickerJadwalkan.Value;
                TimeSpan selisih = waktu - DateTime.Now;

                if (selisih.TotalHours > 24)
                {
                    MessageBox.Show("Waktu jemput maksimal 24 jam dari sekarang!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selisih.TotalHours < 0)
                {
                    MessageBox.Show("Waktu jemput tidak boleh di masa lalu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (frmUtama.consumerLogin == null)
            {
                MessageBox.Show("Anda harus login sebagai consumer untuk membuat pesanan ride!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxDriverWanita.Checked && frmUtama.consumerLogin?.Gender?.ToLower() != "female")
            {
                MessageBox.Show("Hanya konsumen wanita yang dapat meminta driver wanita!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double latPickup = double.Parse(textBoxLatitudeJemput.Text.Trim());
                double lonPickup = double.Parse(textBoxLongitudeJemput.Text.Trim());
                double latDest = double.Parse(textBoxLatitudeTujuan.Text.Trim());
                double lonDest = double.Parse(textBoxLongitudeTujuan.Text.Trim());
                
                double jarak = HitungJarak.HitungJarakKm(latPickup, lonPickup, latDest, lonDest);
                
            DateTime waktu = radioButtonSekarang.Checked ? DateTime.Now : dateTimePickerJadwalkan.Value;
                int tarifPerKm = RideCalculator.GetHargaPerKm(waktu);
                int baseFee = (int)(jarak * tarifPerKm);

            int tambahan = 0;
            if (checkBoxDriverWanita.Checked) tambahan += 1500;
            if (checkBoxMotorBaru.Checked) tambahan += 5000;

                int discountValue = 0;
                if (comboBox1.SelectedItem is Voucher voucher && !string.IsNullOrEmpty(voucher.Value))
                {
                    discountValue = int.Parse(voucher.Value);
                }
                
                int poinDigunakan = (int)numericUpDownPoin.Value;
                if (poinDigunakan % 5000 != 0)
                {
                    MessageBox.Show("Poin yang digunakan harus kelipatan Rp 5.000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                int totalSebelumPoin = baseFee + tambahan - discountValue;
                if (poinDigunakan > totalSebelumPoin)
                {
                    MessageBox.Show($"Poin yang digunakan tidak boleh melebihi total ongkos (Rp {totalSebelumPoin:N0})!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                int total = Math.Max(0, totalSebelumPoin - poinDigunakan);

                Trip trip = new Trip();
                trip.Consumer = frmUtama.consumerLogin;
                trip.Pickup_point = textBoxTitikJemput.Text;
                trip.Destination_point = textBoxTitikTujuan.Text;
                trip.Latitude_pickup = textBoxLatitudeJemput.Text;
                trip.Longitude_pickup = textBoxLongitudeJemput.Text;
                trip.Latitude_dest = textBoxLatitudeTujuan.Text;
                trip.Longitude_dest = textBoxLongitudeTujuan.Text;
                trip.Distance = jarak;
                trip.Pickup_time = waktu.ToString("yyyy-MM-dd HH:mm:ss");
                trip.Fee = tarifPerKm.ToString();
                trip.Rating = 0;
                trip.Additional_fee = tambahan;
                trip.Discount_value = discountValue;
                trip.Total_fee = total;
                trip.Status = "pending";
                trip.Voucher = comboBox1.SelectedItem as Voucher;

                Trip.TambahTrip(trip);
                
                if (poinDigunakan > 0)
                {
                    Consumer.UpdatePoint(poinDigunakan * -1, frmUtama.consumerLogin.Id);
                }
                
                MessageBox.Show("Pesanan ride berhasil dibuat", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuat pesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxLatitudeJemput_TextChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void textBoxLongitudeJemput_TextChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void textBoxLatitudeTujuan_TextChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void textBoxLongitudeTujuan_TextChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void checkBoxDriverWanita_CheckedChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void checkBoxMotorBaru_CheckedChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void dateTimePickerJadwalkan_ValueChanged(object sender, EventArgs e)
        {
            HitungJarakDanOngkos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVoucher = comboBox1.SelectedItem as Voucher;
            HitungJarakDanOngkos();
        }

        private void radioButtonSekarang_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSekarang.Checked)
            {
                dateTimePickerJadwalkan.Enabled = false;
                HitungJarakDanOngkos();
            }
        }

        private void radioButtonJadwalkan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJadwalkan.Checked)
            {
                dateTimePickerJadwalkan.Enabled = true;
                HitungJarakDanOngkos();
            }
        }

        private void numericUpDownPoin_ValueChanged(object sender, EventArgs e)
        {
            int poinDigunakan = (int)numericUpDownPoin.Value;
            if (poinDigunakan % 5000 != 0)
            {
                int rounded = (poinDigunakan / 5000) * 5000;
                numericUpDownPoin.Value = rounded;
                return;
            }
            
            if (frmUtama?.consumerLogin != null)
            {
                int poinTersisa = frmUtama.consumerLogin.Point - poinDigunakan;
                labelPoinTersedia.Text = $"Poin tersedia: {frmUtama.consumerLogin.Point:N0}";
            }
            
            try
            {
                double latPickup = double.Parse(textBoxLatitudeJemput.Text.Trim());
                double lonPickup = double.Parse(textBoxLongitudeJemput.Text.Trim());
                double latDest = double.Parse(textBoxLatitudeTujuan.Text.Trim());
                double lonDest = double.Parse(textBoxLongitudeTujuan.Text.Trim());

                if (latPickup != 0 && lonPickup != 0 && latDest != 0 && lonDest != 0)
                {
                    DateTime waktu = radioButtonSekarang.Checked ? DateTime.Now : dateTimePickerJadwalkan.Value;
                    int tarifPerKm = RideCalculator.GetHargaPerKm(waktu);
                    double jarak = HitungJarak.HitungJarakKm(latPickup, lonPickup, latDest, lonDest);
                    int baseFee = (int)(jarak * tarifPerKm);
                    
                    int tambahan = 0;
                    if (checkBoxDriverWanita.Checked) tambahan += 1500;
                    if (checkBoxMotorBaru.Checked) tambahan += 5000;
                    
                    int diskon = 0;
                    if (comboBox1.SelectedItem is Voucher voucher && !string.IsNullOrEmpty(voucher.Value))
                    {
                        diskon = int.Parse(voucher.Value);
                    }
                    
                    int totalSebelumPoin = baseFee + tambahan - diskon;
                    int maxPoinBisaDigunakan = (totalSebelumPoin / 5000) * 5000;
                    
                    if (poinDigunakan > maxPoinBisaDigunakan)
                    {
                        numericUpDownPoin.Value = maxPoinBisaDigunakan;
                        return;
                    }
                }
            }
            catch { }
            
            HitungJarakDanOngkos();
        }
    }
}
