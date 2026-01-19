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
    public partial class FormTerimaOrder : Form
    {
        string jenis;
        public FormTerimaOrder()
        {
            InitializeComponent();
        }

        private void FormTerimaOrder_Load(object sender, EventArgs e)
        {
            comboBoxJenisOrder.SelectedIndex = 0;
            jenis = comboBoxJenisOrder.Text;
            dataGridViewDaftarOrder.Refresh();
            if (dataGridViewDaftarOrder.Columns.Contains("btnDetail"))
            {
                dataGridViewDaftarOrder.DataSource = null;
                dataGridViewDaftarOrder.Columns.Remove("btnDetail");
            }
            if (jenis == "Gass-ride")
            {
                dataGridViewDaftarOrder.DataSource = Trip.BacaData();
            }
            else if (jenis == "Gass-kan")
            {
                dataGridViewDaftarOrder.DataSource = Order.BacaData();
                dataGridViewDaftarOrder.Columns["Food_rating"].HeaderText = "Food Rating";
                dataGridViewDaftarOrder.Columns["Driver_rating"].HeaderText = "Driver Rating";
                dataGridViewDaftarOrder.Columns["Discount_value"].HeaderText = "Discount Value";
                dataGridViewDaftarOrder.Columns["Total_fee"].HeaderText = "Total Fee";
                dataGridViewDaftarOrder.Columns["Delivery"].HeaderText = "Destination Point";
                dataGridViewDaftarOrder.Columns["Id"].Visible = false;
            }

            if (!dataGridViewDaftarOrder.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                detail.Text = "Detail";
                detail.HeaderText = "Detail";
                detail.UseColumnTextForButtonValue = true;
                detail.Name = "btnDetail";
                dataGridViewDaftarOrder.Columns.Add(detail);
            }

        }
        private void comboBoxJenisOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            jenis = comboBoxJenisOrder.Text;
            dataGridViewDaftarOrder.Refresh();
            if (dataGridViewDaftarOrder.Columns.Contains("btnDetail"))
            {
                dataGridViewDaftarOrder.DataSource = null;
                dataGridViewDaftarOrder.Columns.Remove("btnDetail");
            }
            if (jenis == "Gass-ride")
            {
                dataGridViewDaftarOrder.DataSource = Trip.BacaData();
            }
            else if (jenis == "Gass-kan")
            {
                dataGridViewDaftarOrder.DataSource = Order.BacaData();
                dataGridViewDaftarOrder.Columns["Food_rating"].HeaderText = "Food Rating";
                dataGridViewDaftarOrder.Columns["Driver_rating"].HeaderText = "Driver Rating";
                dataGridViewDaftarOrder.Columns["Discount_value"].HeaderText = "Discount Value";
                dataGridViewDaftarOrder.Columns["Total_fee"].HeaderText = "Total Fee";
                dataGridViewDaftarOrder.Columns["Delivery"].HeaderText = "Destination Point";
                dataGridViewDaftarOrder.Columns["Id"].Visible = false;
            }

            if (!dataGridViewDaftarOrder.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                detail.Text = "Detail";
                detail.HeaderText = "Detail";
                detail.UseColumnTextForButtonValue = true;
                detail.Name = "btnDetail";
                dataGridViewDaftarOrder.Columns.Add(detail);
            }

        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDaftarOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDaftarOrder.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                FormTripDriverDetail frm = new FormTripDriverDetail();
                if(jenis == "Gass-ride")
                {
                    Trip selectedTrip = (Trip)dataGridViewDaftarOrder.CurrentRow.DataBoundItem;
                    frm.tripInfo = selectedTrip;
                }
                else if (jenis == "Gass-kan")
                {
                    Order selectedOrder = (Order)dataGridViewDaftarOrder.CurrentRow.DataBoundItem;
                    frm.orderInfo = selectedOrder;
                }
                frm.Owner = this;
                frm.ShowDialog();
            }
        }
    }
}
