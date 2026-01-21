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
            numericUpDownTahun.Value = 2024;
            string filter = numericUpDownTahun.Value.ToString();
            List<Vehicle> listHasil = Vehicle.BacaData(filter);
            List<Vehicle> listAll = Vehicle.BacaData();
            dataGridViewMonitoringKendaraan.DataSource = listHasil;
            dataGridViewMonitoringKendaraan.Columns["Buy_date"].HeaderText = "Buy Date";
            labelTotalKendaraan.Text = listAll.Count.ToString();
            dataGridViewMonitoringKendaraan.Columns["Id"].Visible = false;

            if (!dataGridViewMonitoringKendaraan.Columns.Contains("btnNotif"))
            {
                DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                hapus.Text = "Beri Notif";
                hapus.HeaderText = "Notifikasi";
                hapus.UseColumnTextForButtonValue = true;
                hapus.Name = "btnNotif";
                dataGridViewMonitoringKendaraan.Columns.Add(hapus);
            }
        }

        private void dataGridViewMonitoringKendaraan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMonitoringKendaraan.Columns["btnNotif"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                Vehicle selectedVehicle = (Vehicle)dataGridViewMonitoringKendaraan.CurrentRow.DataBoundItem;
                FormKirimNotifikasi frmNotif = new FormKirimNotifikasi();
                frmNotif.selectedVehicle = selectedVehicle;
                frmNotif.Owner = this;
                frmNotif.ShowDialog();
            }
        }

        private void numericUpDownTahun_ValueChanged(object sender, EventArgs e)
        {
            string filter = numericUpDownTahun.Value.ToString();
            List<Vehicle> listHasil = Vehicle.BacaData(filter);
            List<Vehicle> listAll = Vehicle.BacaData();
            dataGridViewMonitoringKendaraan.DataSource = listHasil;
            dataGridViewMonitoringKendaraan.Columns["Buy_date"].HeaderText = "Buy Date";
            labelTotalKendaraan.Text = listAll.Count.ToString();
            dataGridViewMonitoringKendaraan.Columns["Id"].Visible = false;

            if (!dataGridViewMonitoringKendaraan.Columns.Contains("btnNotif"))
            {
                DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                hapus.Text = "Beri Notif";
                hapus.HeaderText = "Notifikasi";
                hapus.UseColumnTextForButtonValue = true;
                hapus.Name = "btnNotif";
                dataGridViewMonitoringKendaraan.Columns.Add(hapus);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
