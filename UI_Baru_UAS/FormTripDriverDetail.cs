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
        public Driver driver;
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
                labelOngkos.Text = orderInfo.Delivery.Fee.ToString();
                if(orderInfo.Status == "processing")
                {
                    buttonSelesai.Enabled = false;
                }
                else if (orderInfo.Status == "delivering" )
                {
                    buttonTerima.Enabled = false;
                }
                else if (orderInfo.Status == "cancelled" || orderInfo.Status == "delivered")
                {
                    buttonTerima.Enabled = false;
                    buttonSelesai.Enabled = false;
                }

            }
            else if (tripInfo != null)
            {
                labelIDTrip.Text = tripInfo.Id;
                labelJenis.Text = "Gass-ride";
                labelStatus.Text = tripInfo.Status;
                labelTanggal.Text = tripInfo.Date.ToString("yyyy-MM-dd");
                labelNama.Text = tripInfo.Consumer.Username;
                labelNomor.Text = tripInfo.Consumer.Telp;
                labelJemput.Text = tripInfo.Pickup_point.ToString();
                labelTujuan.Text = tripInfo.Destination_point.ToString();
                labelOngkos.Text = tripInfo.Fee.ToString();
                if (tripInfo.Status == "pending")
                {
                    buttonSelesai.Enabled = false;
                }
                else if (tripInfo.Status == "ongoing")
                {
                    buttonTerima.Enabled = false;
                }
                else if (tripInfo.Status == "canceled" || tripInfo.Status == "completed")
                {
                    buttonTerima.Enabled = false;
                    buttonSelesai.Enabled = false;
                }
            }
        }

        private void buttonTerima_Click(object sender, EventArgs e)
        {
            if (orderInfo != null)
            {
                orderInfo.Status = "delivering";
                Delivery.GantiDriver(driver.Id, orderInfo.Delivery.Id);
                Order.GantiStatus(orderInfo);
            }
            this.Close();
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            if (orderInfo != null)
            {
                orderInfo.Status = "delivered";
                int honor = (int)(orderInfo.Total_fee * 0.2);
                Driver.UpdateSaldo(honor, driver.Id);
                Order.GantiStatus(orderInfo);
            }
            this.Close();
        }
    }
}
