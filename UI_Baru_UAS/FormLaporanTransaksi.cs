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
    public partial class FormLaporanTransaksi : Form
    {
        FormUtama frm;
        public FormLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void comboBoxJenisTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBoxJenisTransaksi.SelectedItem == "Gass-kan")
            {
                if (dataGridViewLaporanTransaksi.Columns.Contains("btnDetail"))
                {
                    dataGridViewLaporanTransaksi.DataSource = null;
                    dataGridViewLaporanTransaksi.Columns.Remove("btnDetail");
                }
                string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
                string akhir = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
                List<Order> listHasil = Order.BacaData("","","",mulai,akhir);
                dataGridViewLaporanTransaksi.DataSource = listHasil;
                dataGridViewLaporanTransaksi.Columns["Food_rating"].HeaderText = "Food Rating";
                dataGridViewLaporanTransaksi.Columns["Driver_rating"].HeaderText = "Driver Rating";
                dataGridViewLaporanTransaksi.Columns["Discount_value"].HeaderText = "Discount Value";
                dataGridViewLaporanTransaksi.Columns["Total_fee"].HeaderText = "Total Fee";
                dataGridViewLaporanTransaksi.Columns["Delivery"].HeaderText = "Destination Point";
                dataGridViewLaporanTransaksi.Columns["Id"].Visible = false;
                int totalFee = listHasil.Sum(order => order.Total_fee);
                labelJumlahTransaksi.Text = $"Rp.{totalFee}";
                labelTotalTransaksi.Text = listHasil.Count.ToString();

                if (!dataGridViewLaporanTransaksi.Columns.Contains("btnDetail"))
                {
                    DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                    detail.Text = "Detail";
                    detail.HeaderText = "Detail";
                    detail.UseColumnTextForButtonValue = true;
                    detail.Name = "btnDetail";
                    dataGridViewLaporanTransaksi.Columns.Add(detail);
                }
            }
            else if ((string)comboBoxJenisTransaksi.SelectedItem == "Gass-ride")
            {
                if(dataGridViewLaporanTransaksi.Columns.Contains("btnDetail"))
                {
                    dataGridViewLaporanTransaksi.DataSource = null;
                    dataGridViewLaporanTransaksi.Columns.Remove("btnDetail");
                }
                string mulai = dateTimePickerDari.Value.Date.ToString("yyyy-MM-dd");
                string akhir = dateTimePickerSampai.Value.Date.ToString("yyyy-MM-dd");
                List<Trip> listHasil = Trip.BacaData(mulai,akhir);
                dataGridViewLaporanTransaksi.DataSource = listHasil;
                dataGridViewLaporanTransaksi.Columns["Longitude_pickup"].HeaderText = "Longitude Pickup";
                dataGridViewLaporanTransaksi.Columns["Latitude_pickup"].HeaderText = "Latitude Pickup";
                dataGridViewLaporanTransaksi.Columns["Longitude_dest"].HeaderText = "Longitude Destination";
                dataGridViewLaporanTransaksi.Columns["Latitude_dest"].HeaderText = "Latitude Destination";
                dataGridViewLaporanTransaksi.Columns["Destination_point"].HeaderText = "Destination Point";
                dataGridViewLaporanTransaksi.Columns["Pickup_time"].HeaderText = "Pickup Time";
                dataGridViewLaporanTransaksi.Columns["Additional_fee"].HeaderText = "Additional Fee";
                dataGridViewLaporanTransaksi.Columns["Discount_value"].HeaderText = "Discount Value";
                dataGridViewLaporanTransaksi.Columns["Total_fee"].HeaderText = "Total Fee";
                dataGridViewLaporanTransaksi.Columns["Id"].Visible = false;
                int totalFee = listHasil.Sum(trip => trip.Total_fee);
                labelJumlahTransaksi.Text = $"Rp.{totalFee}";
                labelTotalTransaksi.Text = listHasil.Count.ToString();

            }
        }

        private void FormLaporanTransaksi_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            comboBoxJenisTransaksi_SelectedIndexChanged(this, e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            comboBoxJenisTransaksi_SelectedIndexChanged(this, e);
        }

        private void dataGridViewLaporanTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewLaporanTransaksi.Columns["btnDetail"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                Order selectedOrder = (Order)dataGridViewLaporanTransaksi.CurrentRow.DataBoundItem;
                FormDetailPesanan frmdetil = new FormDetailPesanan();
                frmdetil.orderInfo = selectedOrder;
                frmdetil.Owner = this;
                frmdetil.ShowDialog();
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if ((string)comboBoxJenisTransaksi.SelectedItem == "Gass-kan")
            {
                string mulai = dateTimePickerDari.Value.Date.ToString("yyyy-MM-dd");
                string akhir = dateTimePickerSampai.Value.Date.ToString("yyyy-MM-dd");
                Order.CetakLaporan(mulai, akhir);
            }
            else if ((string)comboBoxJenisTransaksi.SelectedItem == "Gass-ride")
            {
                string mulai = dateTimePickerDari.Value.Date.ToString("yyyy-MM-dd");
                string akhir = dateTimePickerSampai.Value.Date.ToString("yyyy-MM-dd");
                Trip.CetakLaporan(mulai, akhir);
            }
        }
    }
}