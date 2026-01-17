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
    public partial class FormTopUp : Form
    {
        FormUtama frm;
        public FormTopUp()
        {
            InitializeComponent();
        }

        private void FormTopUp_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            labelSaldoSaatIni.Text = $"Rp. {frm.consumerLogin.Balance}";
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonToUp_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(textBoxNominal.Text);
            TopUp topap = new TopUp();
            topap.Amount = nominal;
            topap.Consumer = frm.consumerLogin;
            frm.consumerLogin.Balance += nominal;
            Consumer.UpdateBalance(frm.consumerLogin);
            TopUp.TambahSaldo(topap);
            MessageBox.Show($"Berhasil Topup sebesar Rp. {nominal}\n" +
                $"Silahkan lakukan transaksi", "Berhasil Topup");
        }
    }
}
