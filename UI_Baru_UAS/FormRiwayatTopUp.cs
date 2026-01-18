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
    public partial class FormRiwayatTopUp : Form
    {
        FormUtama frm;
        public FormRiwayatTopUp()
        {
            InitializeComponent();
        }

        private void FormRiwayatTopUp_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            RefreshData();

        }

        private void RefreshData()
        {
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
            string sampai = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
            List<TopUp> topap = TopUp.BacaData(mulai, sampai, frm.consumerLogin.Id);
            dataGridViewRiwayatTopUp.DataSource = topap;
            int totaltopap = topap.Sum(t => t.Amount);
            labelTotalTopUpPeriodeIni.Text = $"Rp. {totaltopap}";
            dataGridViewRiwayatTopUp.Columns["Id"].Visible = false;
        }
        
        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();

        }
    }
}
