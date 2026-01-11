using Class_Gasslivery;
using System;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormRating : Form
    {
        private Trip trip;

        public FormRating(Trip tripData)
        {
            InitializeComponent();
            trip = tripData;
            LoadData();
        }

        private void LoadData()
        {
            labelIDTransaksi.Text = trip.Id;
            labelJenis.Text = "Ride";

            comboBoxRatingDriver.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                comboBoxRatingDriver.Items.Add(i.ToString());
            }
            comboBoxRatingDriver.SelectedIndex = 0;

            comboBoxRatingTenan.Visible = false;
            label3.Visible = false;
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            if (comboBoxRatingDriver.SelectedItem == null)
            {
                MessageBox.Show("Pilih rating driver terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rating = int.Parse(comboBoxRatingDriver.SelectedItem.ToString());
            trip.Rating = rating;
            trip.Status = "completed";

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
