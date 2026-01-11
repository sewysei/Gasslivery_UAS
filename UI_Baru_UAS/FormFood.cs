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
    public partial class FormFood : Form
    {
        List<OrderDetail> keranjang = new List<OrderDetail>();
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            string halal = "";
            if (checkBoxMenuHalal.Checked)
            {
                halal = "yes";
            }
            else if (!checkBoxMenuHalal.Checked)
            {
                halal = "no";
            }
            List<Tenant> listHasil = Tenant.BacaData();
            comboBoxPilihTenan.DataSource = listHasil; // masih error saat pencet di kerefresh
            comboBoxPilihTenan.DisplayMember = "Name";
            Tenant selectedTenant = (Tenant)comboBoxPilihTenan.SelectedItem;
            List<Class_Gasslivery.Menu> listMenu = Class_Gasslivery.Menu.BacaData(selectedTenant, halal);
            dataGridViewDaftarMenu.DataSource = listMenu;
            double longitude = (double)numericUpDownLongitude.Value;
            double latitude = (double)numericUpDownLatitude.Value;
            double jarak = HitungJarak.HitungJarakKm(double.Parse(selectedTenant.Latitude), double.Parse(selectedTenant.Longitude), latitude, longitude);
            int rate;
            if ((DateTime.Now.Hour >= 11 && DateTime.Now.Hour <= 13) || (DateTime.Now.Hour >= 17 && DateTime.Now.Hour <= 19))
            {
                rate = 1500;
            }
            else
            {
                rate = 750;
            }

            int hitungOngkir = (int)(jarak * rate);
            labelOngkosAntar.Text = $"{hitungOngkir}";

            if (!dataGridViewDaftarMenu.Columns.Contains("btnPesan"))
            {
                DataGridViewButtonColumn pesan = new DataGridViewButtonColumn();
                pesan.Text = "Pesan";
                pesan.HeaderText = "Pesan";
                pesan.UseColumnTextForButtonValue = true;
                pesan.Name = "btnPesan";
                dataGridViewDaftarMenu.Columns.Add(pesan);
            }

            if(keranjang.Count > 0)
            {
                dataGridViewKeranjang.DataSource = keranjang;

                if (!dataGridViewDaftarMenu.Columns.Contains("btnTambah"))
                {
                    DataGridViewButtonColumn tambah = new DataGridViewButtonColumn();
                    tambah.Text = "+";
                    tambah.HeaderText = "Tambah";
                    tambah.UseColumnTextForButtonValue = true;
                    tambah.Name = "btnTambah";
                    dataGridViewDaftarMenu.Columns.Add(tambah);
                }

                if (!dataGridViewDaftarMenu.Columns.Contains("btnKurang"))
                {
                    DataGridViewButtonColumn kurang = new DataGridViewButtonColumn();
                    kurang.Text = "-";
                    kurang.HeaderText = "Kurang";
                    kurang.UseColumnTextForButtonValue = true;
                    kurang.Name = "btnKurang";
                    dataGridViewDaftarMenu.Columns.Add(kurang);
                }

                if (!dataGridViewDaftarMenu.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    hapus.Text = "Hapus";
                    hapus.HeaderText = "Hapus";
                    hapus.UseColumnTextForButtonValue = true;
                    hapus.Name = "btnHapus";
                    dataGridViewDaftarMenu.Columns.Add(hapus);
                }

            }
        }

        private void comboBoxPilihTenan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormFood_Load(this, e);
        }

        private void buttonPesanFood_Click(object sender, EventArgs e)
        {

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxMenuHalal_CheckedChanged(object sender, EventArgs e)
        {
            FormFood_Load(this, e);
        }

        private void dataGridViewDaftarMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarMenu.Columns["btnPesan"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                Class_Gasslivery.Menu selectedMenu = (Class_Gasslivery.Menu)dataGridViewDaftarMenu.CurrentRow.DataBoundItem;
                OrderDetail newOrder = new OrderDetail();
                newOrder.Menu = selectedMenu;
                newOrder.Amount = 1;
                keranjang.Add(newOrder);
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnTambah"].Index)
            {
                OrderDetail selectedOrderDetail = (OrderDetail)dataGridViewDaftarMenu.CurrentRow.DataBoundItem;
                if(selectedOrderDetail.Menu.Stock > selectedOrderDetail.Amount)
                {
                    selectedOrderDetail.Amount += 1;
                }
                else
                {
                    MessageBox.Show("Stok tidak mencukupi");
                }
                FormFood_Load(this, e);
            }

            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnKurang"].Index)
            {
                OrderDetail selectedOrderDetail = (OrderDetail)dataGridViewDaftarMenu.CurrentRow.DataBoundItem;
                if (selectedOrderDetail.Amount > 1)
                {
                    selectedOrderDetail.Amount -= 1;
                }
                else if(selectedOrderDetail.Amount == 1)
                {
                    DialogResult result= MessageBox.Show("Yakin menghapus menu ?", "Hapus Menu", MessageBoxButtons.OKCancel);
                    if(result == DialogResult.OK)
                    {
                        keranjang.Remove(selectedOrderDetail);
                    }
                }
                FormFood_Load(this, e);
            }

            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnHapus"].Index)
            {
                OrderDetail selectedOrderDetail = (OrderDetail)dataGridViewDaftarMenu.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show("Yakin menghapus menu ?", "Hapus Menu", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    keranjang.Remove(selectedOrderDetail);
                }
                FormFood_Load(this, e);
            }
        }

        private void dataGridViewDaftarMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarMenu.Columns["btnPesan"].Index)
            {
                Class_Gasslivery.Menu menu =
                   (Class_Gasslivery.Menu)dataGridViewDaftarMenu.Rows[e.RowIndex].DataBoundItem;

                bool sudahAda = keranjang.Any(k => k.Menu.Id == menu.Id);

                DataGridViewButtonCell btn =
                    (DataGridViewButtonCell)dataGridViewDaftarMenu.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (sudahAda)
                {
                    btn.Value = "";           // tombol kosong
                    btn.ReadOnly = true;      // tidak bisa diklik
                    btn.FlatStyle = FlatStyle.Flat;
                }
                else
                {
                    btn.Value = "Pesan";
                    btn.ReadOnly = false;
                }

                e.FormattingApplied = true;
            }
        }
    }
}
