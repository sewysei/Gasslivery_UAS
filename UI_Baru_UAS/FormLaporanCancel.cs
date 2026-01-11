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
    public partial class FormLaporanCancel : Form
    {
        FormUtama frm;
        public FormLaporanCancel()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporanCancel_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
            string akhir = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
            List<Cancel> listHasil = Cancel.BacaData(mulai, akhir);
            dataGridViewLaporanCancel.DataSource = listHasil;
            dataGridViewLaporanCancel.Columns["Id"].Visible = false;
            labelJumlahCancel.Text = listHasil.Count.ToString();
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            FormLaporanCancel_Load(this,e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            FormLaporanCancel_Load(this, e);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
            string akhir = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
            Cancel.CetakLaporan(mulai,akhir);
        }
    }
}
