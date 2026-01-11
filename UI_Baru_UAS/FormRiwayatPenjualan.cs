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
    public partial class FormRiwayatPenjualan : Form
    {
        public FormRiwayatPenjualan()
        {
            InitializeComponent();
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRiwayatPenjualan_Load(object sender, EventArgs e)
        {
            string mulai = dateTimePickerDari.Value.ToString("yyyy-MM-dd");
            string akhir = dateTimePickerSampai.Value.ToString("yyyy-MM-dd");
            //Order.BacaData
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatPenjualan_Load(this, e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            FormRiwayatPenjualan_Load(this, e);
        }
    }
}
