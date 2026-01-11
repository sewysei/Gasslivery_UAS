using Class_Gasslivery;
using System;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormReportTrip : Form
    {
        private Trip trip;
        public string PesanReport { get; private set; }

        public FormReportTrip(Trip tripData)
        {
            InitializeComponent();
            trip = tripData;
            LoadData();
        }

        private void LoadData()
        {
            labelTripID.Text = trip.Id;
            labelTujuan.Text = trip.Destination_point;
            
            if (trip.Driver != null)
            {
                labelDriver.Text = trip.Driver.Full_name ?? "-";
            }
            else
            {
                labelDriver.Text = "-";
            }
        }

        private void buttonKonfirmasiCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Mohon isi laporan terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PesanReport = textBoxPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
