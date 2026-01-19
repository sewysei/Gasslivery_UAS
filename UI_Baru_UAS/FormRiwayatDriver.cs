using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Gasslivery;

namespace UI_Baru_UAS
{
    public partial class FormRiwayatDriver : Form
    {
        FormUtama frm;
        string jenis;
        public FormRiwayatDriver()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxJenisOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormRiwayatDriver_Load(this, e);
        }

        private void FormRiwayatDriver_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;

            jenis = comboBoxJenisOrder.Text;
            
            if(jenis == "Gass-kan")
            {
                dataGridViewDaftarOrder.DataSource = Order.BacaData("riwayat", "", frm.driverLogin.Id);
                dataGridViewDaftarOrder.Columns["Food_rating"].HeaderText = "Food Rating";
                dataGridViewDaftarOrder.Columns["Driver_rating"].HeaderText = "Driver Rating";
                dataGridViewDaftarOrder.Columns["Discount_value"].HeaderText = "Discount Value";
                dataGridViewDaftarOrder.Columns["Total_fee"].HeaderText = "Total Fee";
                dataGridViewDaftarOrder.Columns["Delivery"].HeaderText = "Destination Point";
                dataGridViewDaftarOrder.Columns["Id"].Visible = false;
            }
            else if(jenis == "Gass-ride")
            {
                dataGridViewDaftarOrder.DataSource = Trip.BacaData();
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

        private void dataGridViewDaftarOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDaftarOrder.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                FormTripDriverDetail frm = new FormTripDriverDetail();
                if (jenis == "Gass-ride")
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
                FormRiwayatDriver_Load(this, e);
            }
        }
    }
}
