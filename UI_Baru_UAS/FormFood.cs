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
            comboBoxPilihTenan.DataSource = listHasil;
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
                OrderDetail keranjang = new OrderDetail();
                keranjang.Menu = selectedMenu;
                keranjang.Amount = 1;
                
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnDetail"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                //Order selectedOrder = (Order)dataGridViewKeranjang.CurrentRow.DataBoundItem;
                //FormDetailPesanan frmdetil = new FormDetailPesanan();
                //frmdetil.orderInfo = selectedOrder;
                //frmdetil.Owner = this;
                //frmdetil.ShowDialog();
            }
        }
    }
}
