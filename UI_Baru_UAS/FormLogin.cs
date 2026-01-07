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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_Baru_UAS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            FormUtama formUtama = (FormUtama)this.Owner;
            formUtama.userLogin = User.CekLogin(username, password);
            if (formUtama.userLogin is null)
                MessageBox.Show("Login Gagal!");
            else
                MessageBox.Show($"Selamat Datang {formUtama.userLogin.Username}");
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
