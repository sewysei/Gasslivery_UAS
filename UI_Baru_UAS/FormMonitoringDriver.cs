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
    public partial class FormMonitoringDriver : Form
    {
        public FormMonitoringDriver()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMonitoringDriver_Load(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;
            string nilai = textBoxCari.Text;
            if(status == "Aktif")
            {
                string kolom = "status";
                List<Driver> listHasil = Driver.BacaData(kolom,nilai);
            }
            else if (status == "Tidak Aktif")
            {

            }
        }
    }
}
