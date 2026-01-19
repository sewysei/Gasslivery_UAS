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
    public partial class FormMonitoringKendaraan : Form
    {
        public FormMonitoringKendaraan()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMonitoringKendaraan_Load(object sender, EventArgs e)
        {
            string nilai = textBoxCari.Text;
            List<Vehicle> listHasil = Vehicle.BacaData(nilai);
            List<Vehicle> listAll = Vehicle.BacaData();
            dataGridViewMonitoringKendaraan.DataSource = listHasil;
            dataGridViewMonitoringKendaraan.Columns["Buy_date"].HeaderText = "Buy Date";
            labelTotalKendaraan.Text = listAll.Count.ToString();
            dataGridViewMonitoringKendaraan.Columns["Id"].Visible = false;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            FormMonitoringKendaraan_Load(this, e);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
