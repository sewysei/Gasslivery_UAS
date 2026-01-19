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
    public partial class FormTripDriverDetail : Form
    {
        public Order orderInfo;
        public Trip tripInfo;
        public FormTripDriverDetail()
        {
            InitializeComponent();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTripDriverDetail_Load(object sender, EventArgs e)
        {
            if(orderInfo != null)
            {
                labelIDTrip.Text = orderInfo.Id;
                labelJenis.Text = "Gass-kan";
                labelStatus.Text = orderInfo.Status;
                labelTanggal.Text = orderInfo.Date.ToString("yyyy-MM-dd");
                labelNama.Text = orderInfo.Consumer.Username;
                labelNomor.Text = orderInfo.Consumer.Telp;
                labelJemput.Text = orderInfo.Tenant.Address;
                labelTujuan.Text = orderInfo.Delivery.Destination_point;
                labelOngkos.Text = orderInfo.Total_fee.ToString();
            }
        }

        private void buttonTerima_Click(object sender, EventArgs e)
        {
            if (orderInfo != null)
            {
                orderInfo.Status = "processing";
                Order.GantiStatus(orderInfo);
            }

        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {

        }
    }
}
