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
    public partial class FormDetailPesanan : Form
    {
        public Order orderInfo;
        public FormDetailPesanan()
        {
            InitializeComponent();
        }

        private void FormDetailPesanan_Load(object sender, EventArgs e)
        {
            List<OrderDetail> listHasil = OrderDetail.BacaData(orderInfo.Id);
            dataGridViewDetailPesanan.DataSource = listHasil;
            dataGridViewDetailPesanan.Columns["Order"].Visible = false;
            int totalPesanan = listHasil.Sum(od => od.Amount);
            labelIDPesanan.Text = orderInfo.Id;
            labelTanggal.Text = orderInfo.Date.ToString("yyyy-MM-dd");
            labelStatus.Text = orderInfo.Status;
            labelKonsumen.Text = orderInfo.Consumer.Username;
            labelAlamat.Text = orderInfo.Delivery.Destination_point;
            labelTotalPesanan.Text = totalPesanan.ToString();
            labelOngkosAntar.Text = orderInfo.Delivery.Fee.ToString();
            labelDiskon.Text = orderInfo.Discount_value.ToString();
            labelTotalBayar.Text = orderInfo.Total_fee.ToString();
            dataGridViewDetailPesanan.Columns["Total_price"].HeaderText = "Total Price";
            if(orderInfo.Food_rating != 0 && orderInfo.Driver_rating != 0)
            {
                buttonRating.Enabled = false;
            }
            if(orderInfo.Status != "delivered")
            {
                buttonVerifikasi.Enabled = false;
            }else
            {
                buttonRating.Enabled = true;
            }

            if (orderInfo.Status != "verified")
            {
                buttonRating.Enabled = false;
            }
            else
            {
                buttonRating.Enabled = true;
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            FormRating rating = new FormRating();
            rating.order = orderInfo;
            rating.Owner = this;
            rating.ShowDialog();
            FormDetailPesanan_Load(this, e);
        }

        private void buttonVerifikasi_Click(object sender, EventArgs e)
        {
            orderInfo.Status = "verified";
            Order.GantiStatus(orderInfo);
            FormDetailPesanan_Load(this, e);
        }
    }
}
