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
    public partial class FormLaporanTransaksi : Form
    {
        FormUtama frm;
        public FormLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void comboBoxJenisTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBoxJenisTransaksi.SelectedItem == "Gass-kan")
            {
                buttonLihatDetail.Visible = true;
            }
            else if ((string)comboBoxJenisTransaksi.SelectedItem == "Gass-ride")
            {
                buttonLihatDetail.Visible = false;
            }
        }

        private void FormLaporanTransaksi_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            List<Trip> listHasil = Trip.BacaData();
            dataGridViewLaporanTransaksi.DataSource = listHasil;
        }
    }
}
