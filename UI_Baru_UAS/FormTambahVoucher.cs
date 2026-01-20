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
    public partial class FormTambahVoucher : Form
    {
        public FormTambahVoucher()
        {
            InitializeComponent();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string conditions = ((int)numericUpDownKondisi.Value).ToString();
            string value = ((int)numericUpDownValue.Value).ToString();
            Voucher voucher = new Voucher();
            voucher.Name = nama;
            voucher.Conditions = conditions;
            voucher.Value = value;
            Voucher.Tambah(voucher);
            MessageBox.Show("Berhasil menambahkan voucher baru");
            textBoxNama.Text = "";
            numericUpDownKondisi.Value = 0;
            numericUpDownValue.Value = 0;
        }

        private void FormTambahVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
