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
    public partial class FormTambahMenu : Form
    {
        FormUtama frm;
        public FormTambahMenu(FormUtama formUtama)
        {
            InitializeComponent();
            frm = formUtama;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string name = textBoxNama.Text;
            int price = (int)numericUpDownHarga.Value;
            int stok = (int)numericUpDownStok.Value;
            string halal = "no";
            if(checkBoxHalal.Checked)
            {
                halal = "yes";
            }
            Class_Gasslivery.Menu menu = new Class_Gasslivery.Menu();
            menu.Name = name;
            menu.Price = price;
            menu.Stock = stok;
            menu.Halal = halal;
            menu.Tenant = frm.tenantLogin;
            Class_Gasslivery.Menu.TambahMenu(menu);
            MessageBox.Show($"{name} berhasil ditambahkan!");
            textBoxNama.Text = "";
            numericUpDownHarga.Value = 0;
            numericUpDownStok.Value = 0;
            checkBoxHalal.Checked = false;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
