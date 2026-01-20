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
    public partial class FormTarikDanaDriver : Form
    {
        FormUtama frm;
        public FormTarikDanaDriver()
        {
            InitializeComponent();
        }

        private void FormTarikDanaDriver_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            labelSaldoSaatIni.Text = ((int)frm.driverLogin.Balance).ToString();
            numericUpDownWithdraw.Maximum = (decimal)frm.driverLogin.Balance;
            if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                buttonTarikDana.Enabled = false;
                MessageBox.Show("Hanya bisa tarik dana di hari Minggu!");
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTarikDana_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            int nominal = (int)numericUpDownWithdraw.Value;
            withdraw.Amount = nominal;
            withdraw.Driver = frm.driverLogin;
            frm.driverLogin.Balance -= nominal; 
            if(nominal == 0)
            {
                MessageBox.Show("Minimal penarikan Rp.10.000", "Minimal Penarikan");
                return;
            }

            if (nominal > frm.driverLogin.Balance)
            {
                MessageBox.Show("Saldo tidak mencukupi", "Saldo tidak Cukup");
                return;
            }
            else
            {
                Withdraw.TarikSaldo(withdraw);
                Driver.UpdateSaldo(nominal * -1, frm.driverLogin.Id);
                MessageBox.Show("Berhasil melakukan penarikan saldo!", "Berhasil menarik saldo");
            }

            FormTarikDanaDriver_Load(this, e);
        }
    }
}
