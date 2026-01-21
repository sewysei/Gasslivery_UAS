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
    public partial class FormRiwayatFood : Form
    {
        FormUtama frm;
        public FormRiwayatFood()
        {
            InitializeComponent();
        }

        private void FormRiwayatFood_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd 00:00:00");
            string sampai = dateTimePickerSampai.Value.ToString("yyyy-MM-dd 23:59:59");

            if (dataGridViewRiwayatFood.Columns.Contains("btnDetail"))
            {
                dataGridViewRiwayatFood.DataSource = null;
                dataGridViewRiwayatFood.Columns.Remove("btnDetail");
            }

            List<Order>listHasil = Order.BacaData("consumer", "", frm.consumerLogin.Id, mulai, sampai);
            dataGridViewRiwayatFood.DataSource = listHasil;
            dataGridViewRiwayatFood.Columns["Id"].Visible = false;
            dataGridViewRiwayatFood.Columns["Food_rating"].Visible = false;
            dataGridViewRiwayatFood.Columns["Driver_rating"].Visible = false;
            dataGridViewRiwayatFood.Columns["Delivery"].HeaderText = "Destination Point";

            if (!dataGridViewRiwayatFood.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
                detail.Text = "Detail";
                detail.HeaderText = "Detail";
                detail.UseColumnTextForButtonValue = true;
                detail.Name = "btnDetail";
                dataGridViewRiwayatFood.Columns.Add(detail);
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatFood_Load(this, e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatFood_Load(this, e);
        }

        private void dataGridViewRiwayatFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRiwayatFood.Columns[e.ColumnIndex].Name == "btnDetail")
            {
                Order selectedOrder = (Order)dataGridViewRiwayatFood.Rows[e.RowIndex].DataBoundItem;
                FormDetailPesanan frm = new FormDetailPesanan();
                frm.orderInfo = selectedOrder;
                frm.Owner = this;
                frm.ShowDialog();
                FormRiwayatFood_Load(this, e);
            }
        }
    }
}
