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
    public partial class FormPesananMasuk : Form
    {
        public FormUtama frmUtama;
        public FormPesananMasuk(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void FormPesananMasuk_Load(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text; 
            List<Order> listHasil = Order.BacaData("status",status,frmUtama.tenantLogin.Id);

            if (dataGridViewPesananMasuk.Columns.Contains("btnTolak"))
            {
                dataGridViewPesananMasuk.DataSource = null;
                dataGridViewPesananMasuk.Columns.Remove("btnTolak");
            }

            if (dataGridViewPesananMasuk.Columns.Contains("btnTerima"))
            {
                dataGridViewPesananMasuk.DataSource = null;
                dataGridViewPesananMasuk.Columns.Remove("btnTerima");
            }

            if (dataGridViewPesananMasuk.Columns.Contains("btnDetail"))
            {
                dataGridViewPesananMasuk.DataSource = null;
                dataGridViewPesananMasuk.Columns.Remove("btnDetail");
            }

            dataGridViewPesananMasuk.DataSource = listHasil;
            dataGridViewPesananMasuk.Columns["Id"].Visible = false;

            if (!dataGridViewPesananMasuk.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                detail.Text = "Detail";
                detail.HeaderText = "Detail";
                detail.UseColumnTextForButtonValue = true;
                detail.Name = "btnDetail";
                dataGridViewPesananMasuk.Columns.Add(detail);
            }

            if (status == "pending")
            {
                if (!dataGridViewPesananMasuk.Columns.Contains("btnTolak"))
                {
                    DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                    detail.Text = "Tolak";
                    detail.HeaderText = "Tolak";
                    detail.UseColumnTextForButtonValue = true;
                    detail.Name = "btnTolak";
                    dataGridViewPesananMasuk.Columns.Add(detail);
                }

                if (!dataGridViewPesananMasuk.Columns.Contains("btnTerima"))
                {
                    DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                    detail.Text = "Terima";
                    detail.HeaderText = "Terima";
                    detail.UseColumnTextForButtonValue = true;
                    detail.Name = "btnTerima";
                    dataGridViewPesananMasuk.Columns.Add(detail);
                }
            }
            
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPesananMasuk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Order selectedOrder = (Order)dataGridViewPesananMasuk.Rows[e.RowIndex].DataBoundItem;

            if (dataGridViewPesananMasuk.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                FormDetailPesanan frm = new FormDetailPesanan();
                frm.orderInfo = selectedOrder;
                frm.Owner = this;
                frm.ShowDialog();
                FormPesananMasuk_Load(this, e);
            }
            else if (dataGridViewPesananMasuk.Columns[e.ColumnIndex].Name == "btnTerima" 
                || dataGridViewPesananMasuk.Columns[e.ColumnIndex].Name == "btnTolak")
            {
                if (selectedOrder.Status != "pending") return;

                if (dataGridViewPesananMasuk.Columns[e.ColumnIndex].Name == "btnTerima")
                {
                    selectedOrder.Status = "processing";
                    Order.GantiStatus(selectedOrder);
                    MessageBox.Show("Pesanan diterima");
                    FormPesananMasuk_Load(this, e);
                }
                else
                {
                    selectedOrder.Status = "cancelled";
                    DialogResult result =  MessageBox.Show("Pesanan dicancel","Cancel",MessageBoxButtons.OKCancel);
                    if(result == DialogResult.OK)
                    {
                        Order.GantiStatus(selectedOrder);
                    }
                    FormPesananMasuk_Load(this, e);
                }
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormPesananMasuk_Load(this, e);
        }

    }
}
