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
    public partial class FormVoucher : Form
    {
        FormUtama frm;

        public FormVoucher()
        {
            InitializeComponent();
        }

        private void dataGridViewVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormVoucher_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            List<Voucher> listHasil = Voucher.BacaData();
            dataGridViewVoucher.DataSource = listHasil;

        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
