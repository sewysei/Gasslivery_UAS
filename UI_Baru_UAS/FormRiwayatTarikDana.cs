using Class_Gasslivery;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
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
    public partial class FormRiwayatTarikDana : Form
    {
        FormUtama frm;
        public FormRiwayatTarikDana()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRiwayatTarikDana_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
            string sampai = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
            List<Withdraw> listHasil = Withdraw.BacaData(mulai, sampai, frm.driverLogin.Id);
            dataGridViewRiwayatPenarikanDana.DataSource = listHasil;
            labelTotalPenarikanPeriodeIni.Text = listHasil.Count.ToString();
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatTarikDana_Load(this, e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatTarikDana_Load(this, e);
        }
    }
}
