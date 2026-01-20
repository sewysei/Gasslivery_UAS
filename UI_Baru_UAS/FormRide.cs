using Class_Gasslivery;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormRide : Form
    {
        public FormUtama frmUtama;
        public FormRide(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void HitungJarakDanOngkos()
        {
            if (!IsKoordinatValid())
            {
                ResetEstimasi();
                return;
            }

            try
            {
                double latPickup = double.Parse(textBoxLatitudeJemput.Text.Trim(), CultureInfo.InvariantCulture);
                double lonPickup = double.Parse(textBoxLangitudeJemput.Text.Trim(), CultureInfo.InvariantCulture);
                double latDest = double.Parse(textBoxLatitudeTujuan.Text.Trim(), CultureInfo.InvariantCulture);
                double lonDest = double.Parse(textBoxLangitudeTujuan.Text.Trim(), CultureInfo.InvariantCulture);

                double jarak = HitungJarak.HitungJarakKm(latPickup, lonPickup, latDest, lonDest);

                if (jarak > 0)
                {
                    labelJarak.Text = jarak.ToString("0.00") + " KM";
                    HitungOngkos(jarak);
                }
                else
                {
                    ResetEstimasi();
                }
            }
            catch
            {
                ResetEstimasi();
            }
        }

        private void HitungOngkos(double jarak)
        {
            if (jarak <= 0)
            {
                labelOngkos.Text = "Rp0";
                return;
            }

            try
            {
                DateTime waktu = radioButtonSekarang.Checked ? DateTime.Now : dateTimePickerJadwalkan.Value;
                int tarifPerKm = RideCalculator.GetHargaPerKm(waktu);
                int baseFee = (int)(jarak * tarifPerKm);
                int tambahan = HitungTambahan();
                int total = baseFee + tambahan - HitungDiskonVoucher();
                
                labelOngkos.Text = "Rp " + Math.Max(0, total).ToString("N0");
            }
            catch
            {
                labelOngkos.Text = "Rp0";
            }
        }

        private bool IsKoordinatValid()
        {
            return !string.IsNullOrWhiteSpace(textBoxLatitudeJemput.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxLangitudeJemput.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxLatitudeTujuan.Text) &&
                   !string.IsNullOrWhiteSpace(textBoxLangitudeTujuan.Text);
        }

        private void ResetEstimasi()
        {
            labelJarak.Text = "-";
            labelOngkos.Text = "Rp0";
        }

        private int HitungTambahan()
        {
            int tambahan = 0;
            if (checkBoxDriverWanita.Checked) tambahan += 1500;
            if (checkBoxMotorBaru.Checked) tambahan += 5000;
            return tambahan;
        }

        private int HitungDiskonVoucher()
        {
            if (comboBox1?.SelectedItem is Voucher voucher && !string.IsNullOrEmpty(voucher.Value))
            {
                return int.Parse(voucher.Value);
            }
            return 0;
        }

        private void buttonPesanRide_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            if (!ValidasiJarak())
                return;

            if (!ValidasiWaktuJemput())
                return;

            if (!ValidasiConsumerLogin())
                return;

            if (!ValidasiDriverWanita())
                return;

            try
            {
                Trip trip = BuatTrip();
                Trip.TambahTrip(trip);
                MessageBox.Show("Pesanan ride berhasil dibuat", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuat pesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxTitikJemput.Text) ||
                string.IsNullOrWhiteSpace(textBoxTitikTujuan.Text) ||
                !IsKoordinatValid())
            {
                MessageBox.Show("Mohon lengkapi semua field yang diperlukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidasiJarak()
        {
            if (labelJarak.Text == "-" || string.IsNullOrEmpty(labelJarak.Text))
            {
                MessageBox.Show("Mohon pastikan koordinat sudah benar untuk menghitung jarak!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidasiWaktuJemput()
        {
            if (!radioButtonSekarang.Checked)
            {
                DateTime waktu = dateTimePickerJadwalkan.Value;
                TimeSpan selisih = waktu - DateTime.Now;

                if (selisih.TotalHours > 24)
                {
                    MessageBox.Show("Waktu jemput maksimal 24 jam dari sekarang!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (selisih.TotalHours < 0)
                {
                    MessageBox.Show("Waktu jemput tidak boleh di masa lalu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool ValidasiConsumerLogin()
        {
            if (frmUtama.consumerLogin == null)
            {
                MessageBox.Show("Anda harus login sebagai consumer untuk membuat pesanan ride!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidasiDriverWanita()
        {
            if (checkBoxDriverWanita.Checked &&
                (frmUtama.consumerLogin?.Gender?.ToLower() != "female"))
            {
                MessageBox.Show("Hanya konsumen wanita yang dapat meminta driver wanita!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Trip BuatTrip()
        {
            double jarak = Convert.ToDouble(labelJarak.Text.Replace(" KM", "").Replace(" ", ""));
            DateTime waktu = radioButtonSekarang.Checked ? DateTime.Now : dateTimePickerJadwalkan.Value;
            int tarifPerKm = RideCalculator.GetHargaPerKm(waktu);
            int baseFee = (int)(jarak * tarifPerKm);
            int tambahan = HitungTambahan();
            int discountValue = HitungDiskonVoucher();
            int total = Math.Max(0, baseFee + tambahan - discountValue);

            Voucher voucher = comboBox1.SelectedItem as Voucher;

            Trip trip = new Trip
            {
                Consumer = frmUtama.consumerLogin,
                Pickup_point = textBoxTitikJemput.Text,
                Destination_point = textBoxTitikTujuan.Text,
                Latitude_pickup = textBoxLatitudeJemput.Text,
                Longitude_pickup = textBoxLangitudeJemput.Text,
                Latitude_dest = textBoxLatitudeTujuan.Text,
                Longitude_dest = textBoxLangitudeTujuan.Text,
                Distance = jarak,
                Pickup_time = waktu.ToString("yyyy-MM-dd HH:mm:ss"),
                Fee = tarifPerKm.ToString(),
                Rating = 0,
                Additional_fee = tambahan,
                Discount_value = discountValue,
                Total_fee = total,
                Status = "pending",
                Voucher = voucher
            };

            return trip;
        }

        private void FormRide_Load(object sender, EventArgs e)
        {
            InisialisasiDateTimePicker();
            LoadVoucher();
            AttachEventHandlers();
            SetDriverWanitaVisibility();
            HitungOngkosJikaDataAda();
        }

        private void InisialisasiDateTimePicker()
        {
            dateTimePickerJadwalkan.MinDate = DateTime.Now;
            dateTimePickerJadwalkan.MaxDate = DateTime.Now.AddHours(24);
            dateTimePickerJadwalkan.Value = DateTime.Now.AddHours(1);
            dateTimePickerJadwalkan.Enabled = false;
        }

        private void LoadVoucher()
        {
            comboBox1.Items.Clear();
            
            foreach (Voucher v in Voucher.BacaData())
            {
                comboBox1.Items.Add(v);
            }
            
            comboBox1.SelectedIndex = 0;
        }

        private void AttachEventHandlers()
        {
            textBoxLatitudeJemput.TextChanged += (s, ev) => HitungJarakDanOngkos();
            textBoxLangitudeJemput.TextChanged += (s, ev) => HitungJarakDanOngkos();
            textBoxLatitudeTujuan.TextChanged += (s, ev) => HitungJarakDanOngkos();
            textBoxLangitudeTujuan.TextChanged += (s, ev) => HitungJarakDanOngkos();
            checkBoxDriverWanita.CheckedChanged += (s, ev) => HitungJarakDanOngkos();
            checkBoxMotorBaru.CheckedChanged += (s, ev) => HitungJarakDanOngkos();
            dateTimePickerJadwalkan.ValueChanged += (s, ev) => HitungJarakDanOngkos();
            comboBox1.SelectedIndexChanged += (s, ev) => HitungJarakDanOngkos();
            radioButtonSekarang.CheckedChanged += RadioButtonSekarang_CheckedChanged;
            radioButtonJadwalkan.CheckedChanged += RadioButtonJadwalkan_CheckedChanged;
            buttonBatal.Click += ButtonBatal_Click;
        }

        private void SetDriverWanitaVisibility()
        {
            bool isFemale = frmUtama.consumerLogin?.Gender?.ToLower() == "female";
            
            if (!isFemale)
            {
                checkBoxDriverWanita.Enabled = false;
                checkBoxDriverWanita.Text = "Driver Wanita (Hanya untuk konsumen wanita)";
            }
        }

        private void HitungOngkosJikaDataAda()
        {
            this.BeginInvoke(new Action(() =>
            {
                if (IsKoordinatValid())
                {
                    HitungJarakDanOngkos();
                }
            }));
        }

        private void RadioButtonSekarang_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSekarang.Checked)
            {
                dateTimePickerJadwalkan.Enabled = false;
                HitungJarakDanOngkos();
            }
        }

        private void RadioButtonJadwalkan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJadwalkan.Checked)
            {
                dateTimePickerJadwalkan.Enabled = true;
                HitungJarakDanOngkos();
            }
        }

        private void ButtonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
