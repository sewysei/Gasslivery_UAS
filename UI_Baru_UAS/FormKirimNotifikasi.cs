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
    public partial class FormKirimNotifikasi : Form
    {
        public Vehicle selectedVehicle;
        public FormKirimNotifikasi()
        {
            InitializeComponent();
        }

        private void FormKirimNotifikasi_Load(object sender, EventArgs e)
        {
            labelDriver.Text = selectedVehicle.Driver.Full_name;
            textBox1.Focus();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        { 
            Notification notification = new Notification();
            string message = textBox1.Text;
            notification.Driver = selectedVehicle.Driver;
            notification.Message = message;
            Notification.TambahNotifikasi(notification);
            MessageBox.Show($"Notifikasi berhasil dikirim ke {selectedVehicle.Driver.Full_name}", "Berhasil mengirim Notifikasi!");
            textBox1.Text = "";
        }

        private void radioButtonSemuaDriver_CheckedChanged(object sender, EventArgs e)
        {
            FormKirimNotifikasi_Load(this, e);
        }

        private void radioButtonDriverTertentu_CheckedChanged(object sender, EventArgs e)
        {
            FormKirimNotifikasi_Load(this,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
