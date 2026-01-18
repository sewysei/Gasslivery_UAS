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
    public partial class FormNotifikasiDriver : Form
    {
        FormUtama frm;
        public FormNotifikasiDriver()
        {
            InitializeComponent();
        }

        private void FormNotifikasiDriver_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;

            if (frm.driverLogin == null)
            {
                MessageBox.Show("Driver belum login");
                return;
            }
            List<Notification> listNotif =  Notification.BacaData(frm.driverLogin.Id);
            dataGridViewNotifikasiDriver.DataSource = listNotif;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            List<Notification> listNotif = Notification.BacaData(frm.driverLogin.Id);
            dataGridViewNotifikasiDriver.DataSource = listNotif;
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
