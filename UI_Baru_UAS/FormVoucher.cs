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
            if (e.ColumnIndex == dataGridViewVoucher.Columns["btnHapus"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                Voucher selectedVoucher = (Voucher)dataGridViewVoucher.CurrentRow.DataBoundItem;
                Voucher.Hapus(selectedVoucher);
                MessageBox.Show("Berhasil menghapus voucher!");
                FormVoucher_Load(this, e);
            }
        }

        private void FormVoucher_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            List<Voucher> listHasil = Voucher.BacaData();
            dataGridViewVoucher.DataSource = listHasil;
            dataGridViewVoucher.Columns["Id"].Visible = false;

            if (frm.adminLogin == null)
            {
                buttonTambah.Visible = false;
                buttonTambah.Enabled = false;
            }
            else if (frm.adminLogin != null)
            {
                if (!dataGridViewVoucher.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    hapus.Text = "Hapus";
                    hapus.HeaderText = "Hapus";
                    hapus.UseColumnTextForButtonValue = true;
                    hapus.Name = "btnHapus";
                    dataGridViewVoucher.Columns.Add(hapus);
                }
                buttonTambah.Visible = true;
                buttonTambah.Enabled = true;
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahVoucher frmTambah = new FormTambahVoucher();
            frmTambah.Owner = this;
            frmTambah.ShowDialog();
            FormVoucher_Load(this, e);
        }
    }
}
