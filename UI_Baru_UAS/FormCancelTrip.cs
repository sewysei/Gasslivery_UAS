using Class_Gasslivery;
using System;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormCancelTrip : Form
    {
        private Trip trip;
        public string AlasanCancel { get; private set; }

        public FormCancelTrip(Trip tripData)
        {
            InitializeComponent();
            trip = tripData;
            LoadData();
        }

        private void LoadData()
        {
            labelTripID.Text = trip.Id;
            labelTujuan.Text = trip.Destination_point;
        }

        private void buttonKonfirmasiCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Mohon isi alasan pembatalan terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlasanCancel = textBoxPassword.Text;
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
