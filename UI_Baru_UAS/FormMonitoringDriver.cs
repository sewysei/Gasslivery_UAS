using Class_Gasslivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormMonitoringDriver : Form
    {
        public FormMonitoringDriver()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMonitoringDriver_Load(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;
            string kolom = "status";
            List<Driver> listAll = Driver.BacaData();
            if(status == "Aktif")
            {
                string nilai = "active";
                List<Driver> listHasil = Driver.BacaData(kolom,nilai);
                dataGridViewMonitoringDriver.DataSource = listHasil;
                dataGridViewMonitoringDriver.Columns["Full_name"].HeaderText = "Full Name";
                dataGridViewMonitoringDriver.Columns["Avg_rating"].HeaderText = "Avg Rating";
                labelTotalDriver.Text = listAll.Count.ToString();
                labelActive.Text = listHasil.Count.ToString();
                labelInactive.Text = (listAll.Count - listHasil.Count).ToString();
            }
            else if (status == "Tidak Aktif")
            { 
                string nilai = "inactive";
                List<Driver> listHasil = Driver.BacaData(kolom, nilai);
                dataGridViewMonitoringDriver.DataSource = listHasil;
                dataGridViewMonitoringDriver.Columns["Full_name"].HeaderText = "Full Name";
                dataGridViewMonitoringDriver.Columns["Avg_rating"].HeaderText = "Avg Rating";
                labelTotalDriver.Text = listAll.Count.ToString();
                labelInactive.Text = listHasil.Count.ToString();
                labelActive.Text = (listAll.Count - listHasil.Count).ToString();
            }
            dataGridViewMonitoringDriver.Columns["Id"].Visible = false;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormMonitoringDriver_Load(this, e);
        }
    }
}
