using Class_Gasslivery;
using System;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormRating : Form
    {
        public Trip trip;
        public Order order;
        public FormRating()
        {
            InitializeComponent();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            if(trip != null)
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
            else if (order != null)
            {
                if (comboBoxRatingDriver.SelectedItem == null || comboBoxRatingTenan.SelectedItem == null)
                {
                    MessageBox.Show("Pilih rating terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int ratingDriver = int.Parse(comboBoxRatingDriver.SelectedItem.ToString());
                int ratingTenant = int.Parse(comboBoxRatingTenan.SelectedItem.ToString());
                order.Driver_rating = ratingDriver;
                order.Food_rating = ratingDriver;
                Order.GantiRating(order);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormRating_Load(object sender, EventArgs e)
        {
            if (trip != null)
            {
                labelIDTransaksi.Text = trip.Id;
                labelJenis.Text = "Gass-ride";

                comboBoxRatingDriver.Items.Clear();
                for (int i = 1; i <= 5; i++)
                {
                    comboBoxRatingDriver.Items.Add(i.ToString());
                }
                comboBoxRatingDriver.SelectedIndex = 0;

                comboBoxRatingTenan.Visible = false;
                label3.Visible = false;
            }
            else if (order != null)
            {
                comboBoxRatingTenan.Visible = true;
                labelJenis.Text = "Gass-kan";
                labelIDTransaksi.Text = order.Id;
                comboBoxRatingDriver.Items.Clear();
                comboBoxRatingTenan.Items.Clear();
                for (int i = 1; i <= 5; i++)
                {
                    comboBoxRatingDriver.Items.Add(i.ToString());
                    comboBoxRatingTenan.Items.Add(i.ToString());
                }
                comboBoxRatingDriver.SelectedIndex = 0;
                comboBoxRatingTenan.SelectedIndex = 0;

                label3.Visible = true;
            }
        }
    }
}
