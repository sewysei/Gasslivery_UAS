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
        public FormKirimNotifikasi()
        {
            InitializeComponent();
        }

        private void FormKirimNotifikasi_Load(object sender, EventArgs e)
        {
            List<Driver> listDriver = Driver.BacaData();
            comboBox1.DataSource = listDriver;
            comboBox1.DisplayMember = "Nama";
            if(radioButtonSemuaDriver.Checked)
            {
                comboBox1.Enabled = false;
            }
            else if (radioButtonDriverTertentu.Checked)
            {
                comboBox1.Enabled = true;
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            if(radioButtonDriverTertentu.Checked)
            {
                Driver selectedDriver = (Driver)comboBox1.SelectedItem;
                Notification notification = new Notification();
                string message = textBox1.Text;
                notification.Driver = selectedDriver;
                notification.Message = message;
                Notification.TambahNotifikasi(notification);
                MessageBox.Show($"Notifikasi berhasil dikirim ke {selectedDriver.Full_name}", "Berhasil mengirim Notifikasi!");
            }
            else if (radioButtonSemuaDriver.Checked)
            {
                List<Driver> listDriver = Driver.BacaData();
                for (int i = 0; i < listDriver.Count; i++)
                {
                    Driver selectedDriver = listDriver[i];
                    Notification notification = new Notification();
                    string message = textBox1.Text;
                    notification.Driver = selectedDriver;
                    notification.Message = message;
                    Notification.TambahNotifikasi(notification);
                }
                MessageBox.Show($"Notifikasi berhasil dikirim ke semua driver! ", "Berhasil mengirim Notifikasi!");
            }
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void radioButtonSemuaDriver_CheckedChanged(object sender, EventArgs e)
        {
            FormKirimNotifikasi_Load(this, e);
        }

        private void radioButtonDriverTertentu_CheckedChanged(object sender, EventArgs e)
        {
            FormKirimNotifikasi_Load(this,e);
        }
    }
}
