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
    public partial class FormKelolaMenu : Form
    {
        public FormUtama frmUtama;
        public FormKelolaMenu(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void FormKelolaMenu_Load(object sender, EventArgs e)
        {
            List<Class_Gasslivery.Menu> listMenu = Class_Gasslivery.Menu.BacaData(frmUtama.tenantLogin);
            dataGridViewKelolaMenu.DataSource = listMenu;

            if (!dataGridViewKelolaMenu.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                hapus.Text = "Hapus";
                hapus.HeaderText = "Hapus";
                hapus.UseColumnTextForButtonValue = true;
                hapus.Name = "btnHapus";
                dataGridViewKelolaMenu.Columns.Add(hapus);
            }

        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahMenu frmtambah = new FormTambahMenu(frmUtama);
            frmtambah.Owner = this;
            frmtambah.ShowDialog();
            FormKelolaMenu_Load(this, e);
        }

        private void dataGridViewKelolaMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKelolaMenu.Columns["btnHapus"].Index)
            {
                Class_Gasslivery.Menu selectedMenu = (Class_Gasslivery.Menu)dataGridViewKelolaMenu.CurrentRow.DataBoundItem;
                DialogResult dialog = MessageBox.Show($"Hapus menu {selectedMenu.Name} ?", "Hapus Menu", MessageBoxButtons.OKCancel);
                if(dialog == DialogResult.OK)
                {
                    Class_Gasslivery.Menu.HapusMenu(selectedMenu);
                }
                FormKelolaMenu_Load(this, e);
            }
        }
    }
}
