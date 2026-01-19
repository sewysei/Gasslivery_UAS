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
    public partial class FormRiwayatPenjualan : Form
    {
        FormUtama frm;
        public FormRiwayatPenjualan()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRiwayatPenjualan_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
            string akhir = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
            List<Order>listHasil =  Order.BacaData("date", "", frm.tenantLogin.Id, mulai, akhir);
            dataGridViewRiwayatPenjualan.DataSource = listHasil;
            dataGridViewRiwayatPenjualan.Columns["Id"].Visible = false;
            if (!dataGridViewRiwayatPenjualan.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                detail.Text = "Detail";
                detail.HeaderText = "Detail";
                detail.UseColumnTextForButtonValue = true;
                detail.Name = "btnDetail";
                dataGridViewRiwayatPenjualan.Columns.Add(detail);
            }
            int totalFee = listHasil.Sum(order => order.Total_fee);
            labelTotalPenjualanPeriodeIni.Text = $"Rp.{totalFee}";
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatPenjualan_Load(this, e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatPenjualan_Load(this, e);
        }

        private void dataGridViewRiwayatPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRiwayatPenjualan.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                Order selectedOrder = (Order)dataGridViewRiwayatPenjualan.Rows[e.RowIndex].DataBoundItem;
                FormDetailPesanan frm = new FormDetailPesanan();
                frm.orderInfo = selectedOrder;
                frm.Owner = this;
                frm.ShowDialog();
            }
        }
    }
}
