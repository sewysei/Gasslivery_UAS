using Class_Gasslivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Consumer consumerLogin;

        private void HitungJarakDanOngkos()
        {
            if (
                textBoxLatitudeJemput.Text == "" ||
                textBoxLangitudeJemput.Text == "" ||
                textBoxLatitudeTujuan.Text == "" ||
                textBoxLangitudeTujuan.Text == ""
            ) return;

            double latPickup = double.Parse(textBoxLatitudeJemput.Text, CultureInfo.InvariantCulture);
            double lonPickup = double.Parse(textBoxLangitudeJemput.Text, CultureInfo.InvariantCulture);
            double latDest = double.Parse(textBoxLatitudeTujuan.Text, CultureInfo.InvariantCulture);
            double lonDest = double.Parse(textBoxLangitudeTujuan.Text, CultureInfo.InvariantCulture);

            double jarak = GeoHelper.HitungJarak(latPickup, lonPickup, latDest, lonDest);

            labelJarak.Text = jarak.ToString("0.00") + " KM";
            HitungOngkos(jarak);
        }

        private void HitungOngkos(double jarak)
        {
            DateTime waktu = radioButtonSekarang.Checked
                ? DateTime.Now
                : dateTimePickerJadwalkan.Value;

            int total = RideCalculator.HitungTotal(
                jarak,
                waktu,
                checkBoxDriverWanita.Checked,
                checkBoxMotorBaru.Checked
            );

            labelOngkos.Text = "Rp " + total.ToString("N0");
        }

        private void buttonPesanRide_Click(object sender, EventArgs e)
        {
            double jarak = Convert.ToDouble(labelJarak.Text.Replace(" KM", ""));
            DateTime waktu = radioButtonSekarang.Checked ? DateTime.Now : dateTimePickerJadwalkan.Value;

            int tarif = RideCalculator.GetHargaPerKm(waktu);
            int tambahan = 0;

            if (checkBoxDriverWanita.Checked) tambahan += 1500;
            if (checkBoxMotorBaru.Checked) tambahan += 5000;

            int total = RideCalculator.HitungTotal(
                jarak, waktu,
                checkBoxDriverWanita.Checked,
                checkBoxMotorBaru.Checked
            );

            string sql = $@"
    INSERT INTO trips
    (consumer_id, pickup_point, destination_point,
     latitude_pickup, longitude_pickup,
     latitude_dest, longitude_dest,
     distance, pickup_time,
     fee, additional_fee, total_fee,
     status, date)
    VALUES
    (
        {consumerLogin.Id},
        '{textBoxTitikJemput.Text.Replace("'", "")}',
        '{textBoxTitikTujuan.Text.Replace("'", "")}',
        '{textBoxLatitudeJemput.Text}',
        '{textBoxLangitudeJemput.Text}',
        '{textBoxLatitudeTujuan.Text}',
        '{textBoxLangitudeTujuan.Text}',
        {jarak},
        '{waktu:yyyy-MM-dd HH:mm:ss}',
        {tarif},
        {tambahan},
        {total},
        'ongoing',
        NOW()
    )";

            Koneksi.JalankanPerintahDML(sql);

            MessageBox.Show("Pesanan ride berhasil dibuat");
            this.Close();
        }

        private void FormRide_Load(object sender, EventArgs e)
        {
            textBoxLatitudeJemput.TextChanged += (s, ev) => HitungJarakDanOngkos();
            textBoxLangitudeJemput.TextChanged += (s, ev) => HitungJarakDanOngkos();
            textBoxLatitudeTujuan.TextChanged += (s, ev) => HitungJarakDanOngkos();
            textBoxLangitudeTujuan.TextChanged += (s, ev) => HitungJarakDanOngkos();

            checkBoxDriverWanita.CheckedChanged += (s, ev) => HitungJarakDanOngkos();
            checkBoxMotorBaru.CheckedChanged += (s, ev) => HitungJarakDanOngkos();
            dateTimePickerJadwalkan.ValueChanged += (s, ev) => HitungJarakDanOngkos();
        }

        private void FormRide_Load(object sender, EventArgs e)
        {
                
        }
    }
}
