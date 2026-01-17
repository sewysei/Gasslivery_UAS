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
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI_Baru_UAS
{
    public partial class FormFood : Form
    {
        public Consumer consumerLogin;
        Voucher selectedVoucher;
        Tenant selectedTenant;
        BindingList<OrderDetail> keranjang = new BindingList<OrderDetail>();
        BindingList<Class_Gasslivery.Menu> menu;
        BindingList<Tenant> listTenant;
        int totalMakanan;
        int totalBayar;
        int ongkir;
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            comboBoxVocer.Items.Clear();
            List<Voucher> vocer = new List<Voucher>(Voucher.BacaData());
            comboBoxVocer.DataSource = vocer;
            comboBoxVocer.DisplayMember = "Name";     
            selectedVoucher = comboBoxVocer.SelectedItem as Voucher;

            string halal = "";
            if(checkBoxMenuHalal.Checked)
            {
                halal = "yes";
            }
            else if (!checkBoxMenuHalal.Checked)
            {
                halal = "";
            }

            if (dataGridViewDaftarMenu.Columns.Contains("btnPesan"))
            {
                dataGridViewDaftarMenu.DataSource = null;
                dataGridViewDaftarMenu.Columns.Remove("btnPesan");
            }

            listTenant = new BindingList<Tenant>(Tenant.BacaData());
            
            comboBoxPilihTenan.DataSource = listTenant;
            comboBoxPilihTenan.DisplayMember = "Name";

            selectedTenant = (Tenant)comboBoxPilihTenan.SelectedItem;
            menu = new BindingList<Class_Gasslivery.Menu>(Class_Gasslivery.Menu.BacaData(selectedTenant,halal ));
            dataGridViewDaftarMenu.DataSource = menu;

            dataGridViewKeranjang.DataSource = keranjang;
            
            if (dataGridViewDaftarMenu.Columns["btnPesan"] == null)
            {
                dataGridViewDaftarMenu.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "btnPesan",
                    HeaderText = "Pesan",
                    Text = "Pesan",
                    UseColumnTextForButtonValue = true
                });
            }

            if(keranjang.Count > 0)
            {
                dataGridViewKeranjang.DataSource = keranjang;

                if (!dataGridViewKeranjang.Columns.Contains("btnTambah"))
                {
                    DataGridViewButtonColumn tambah = new DataGridViewButtonColumn();
                    tambah.Text = "+";
                    tambah.HeaderText = "Tambah";
                    tambah.UseColumnTextForButtonValue = true;
                    tambah.Name = "btnTambah";
                    dataGridViewKeranjang.Columns.Add(tambah);
                }

                if (!dataGridViewKeranjang.Columns.Contains("btnKurang"))
                {
                    DataGridViewButtonColumn kurang = new DataGridViewButtonColumn();
                    kurang.Text = "-";
                    kurang.HeaderText = "Kurang";
                    kurang.UseColumnTextForButtonValue = true;
                    kurang.Name = "btnKurang";
                    dataGridViewKeranjang.Columns.Add(kurang);
                }

                if (!dataGridViewKeranjang.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    hapus.Text = "Hapus";
                    hapus.HeaderText = "Hapus";
                    hapus.UseColumnTextForButtonValue = true;
                    hapus.Name = "btnHapus";
                    dataGridViewKeranjang.Columns.Add(hapus);
                }

            }
            
        }

        private void RefreshDGV()
        {
            string halal = "";

            if (checkBoxMenuHalal.Checked)
            {
                halal = "yes";
            }
            else if (!checkBoxMenuHalal.Checked)
            {
                halal = "";
            }

            if (dataGridViewDaftarMenu.Columns.Contains("btnPesan"))
            {
                dataGridViewDaftarMenu.DataSource = null;
                dataGridViewDaftarMenu.Columns.Remove("btnPesan");
            }

            selectedTenant = (Tenant)comboBoxPilihTenan.SelectedItem;
            menu = new BindingList<Class_Gasslivery.Menu>(Class_Gasslivery.Menu.BacaData(selectedTenant, halal));
            dataGridViewDaftarMenu.DataSource = menu;
            dataGridViewKeranjang.DataSource = keranjang;

            if (dataGridViewDaftarMenu.Columns["btnPesan"] == null)
            {
                dataGridViewDaftarMenu.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "btnPesan",
                    HeaderText = "Pesan",
                    Text = "Pesan",
                    UseColumnTextForButtonValue = true
                });
            }

            if (keranjang.Count > 0)
            {
                dataGridViewKeranjang.DataSource = keranjang;
                dataGridViewKeranjang.Columns["Order"].Visible = false;
                dataGridViewKeranjang.Refresh();
                if (!dataGridViewKeranjang.Columns.Contains("btnTambah"))
                {
                    DataGridViewButtonColumn tambah = new DataGridViewButtonColumn();
                    tambah.Text = "+";
                    tambah.HeaderText = "Tambah";
                    tambah.UseColumnTextForButtonValue = true;
                    tambah.Name = "btnTambah";
                    dataGridViewKeranjang.Columns.Add(tambah);
                }

                if (!dataGridViewKeranjang.Columns.Contains("btnKurang"))
                {
                    DataGridViewButtonColumn kurang = new DataGridViewButtonColumn();
                    kurang.Text = "-";
                    kurang.HeaderText = "Kurang";
                    kurang.UseColumnTextForButtonValue = true;
                    kurang.Name = "btnKurang";
                    dataGridViewKeranjang.Columns.Add(kurang);
                }

                if (!dataGridViewKeranjang.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    hapus.Text = "Hapus";
                    hapus.HeaderText = "Hapus";
                    hapus.UseColumnTextForButtonValue = true;
                    hapus.Name = "btnHapus";
                    dataGridViewKeranjang.Columns.Add(hapus);
                }

            }
        }
        private void comboBoxPilihTenan_SelectedIndexChanged(object sender, EventArgs e)
        {
            keranjang = new BindingList<OrderDetail>();
            RefreshDGV();
        }

        private void buttonPesanFood_Click(object sender, EventArgs e)
        {
            if(int.Parse(selectedVoucher.Conditions) > totalBayar)
            {
                MessageBox.Show("Voucher yang dipilih tidak memenuhi syarat penggunaan, pilih voucher lain", "Voucher");
                return;
            }
            Order pesananBaru = new Order();
            pesananBaru.Tenant = selectedTenant;
            pesananBaru.Voucher = selectedVoucher;
            pesananBaru.Discount_value = int.Parse(selectedVoucher.Value);
            pesananBaru.Status = "pending";
            pesananBaru.Tip = 0;
            pesananBaru.Total_fee = totalBayar - pesananBaru.Discount_value;
            if (pesananBaru.Total_fee > consumerLogin.Balance)
            {
                MessageBox.Show("Saldo Gass-mon Anda tidak mencukupi, mohon topup terlebih dahulu \n " +
                    $"Saldo Anda: Rp. {consumerLogin.Balance} \n " +
                    $"Total Transaksi: Rp. {pesananBaru.Total_fee} ", "Saldo Tidak Mencukupi");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Konfirmasi pembayaran \n " +
                    $"Saldo Anda: Rp. {consumerLogin.Balance} \n " +
                    $"Total Transaksi: Rp. {pesananBaru.Total_fee} ", "Konfirmasi", MessageBoxButtons.OKCancel);

                if(dialog == DialogResult.OK)
                {

                    pesananBaru.Consumer = consumerLogin;
                    int idOrderBaru = Order.BuatOrderan(pesananBaru);
                    if(idOrderBaru != 0)
                    {
                        int total = 0;
                        foreach(OrderDetail od in keranjang)
                        {
                            total += od.Total_price;
                            OrderDetail.BuatOrderDetail(od,idOrderBaru);
                        }
                        consumerLogin.Balance -= total;
                        Consumer.UpdateBalance(consumerLogin);
                        MessageBox.Show("Pesanan Berhasil dibuat, tunggu konfirmasi tenant.", "Berhasil");
                    }
                }
                else
                {
                    MessageBox.Show("Pesanan tidak jadi dibuat ", "Cancel Pesanan");
                }
            }

        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxMenuHalal_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void dataGridViewDaftarMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dataGridViewDaftarMenu.Columns["btnPesan"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                Class_Gasslivery.Menu selectedMenu = (Class_Gasslivery.Menu)dataGridViewDaftarMenu.CurrentRow.DataBoundItem;
                if ((Class_Gasslivery.Menu)selectedMenu == null) return;
                bool isOrdered = false;
                
                if (keranjang.Count > 0) {
                    totalMakanan = 0;
                    foreach ( OrderDetail od in keranjang)
                    {
                        if(od.Menu.Name == selectedMenu.Name)
                        {
                            isOrdered = true;
                            od.Amount += 1;
                        }

                        od.Total_price = od.Amount * od.Menu.Price;
                    }
                }

                if (isOrdered == false)
                {
                    OrderDetail detail = new OrderDetail();
                    detail.Menu = selectedMenu;
                    detail.Amount = 1;
                    detail.Total_price = selectedMenu.Price;
                    keranjang.Add(detail);
                }

                totalMakanan = keranjang.Sum(x => x.Total_price);
                totalBayar = totalMakanan + ongkir;
                labelTotalMakanan.Text = $"Rp. {totalMakanan}";
                labelTotalBayar.Text = $"Rp. {totalBayar}";
                RefreshDGV();
            }

        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnTambah"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                if((OrderDetail)dataGridViewKeranjang.CurrentRow.DataBoundItem == null) return;
                OrderDetail detail = (OrderDetail)dataGridViewKeranjang.CurrentRow.DataBoundItem;
                if(detail.Menu.Stock > detail.Amount)
                {
                    detail.Amount += 1;
                    detail.Total_price = detail.Amount * detail.Menu.Price;
                }
                else
                {
                    MessageBox.Show("Stok tidak mencukupi", "Stok Kurang");
                }

                totalMakanan = 0;
                foreach (OrderDetail od in keranjang)
                {
                    totalMakanan += od.Total_price;
                }

                totalBayar = totalMakanan + ongkir;
                labelTotalMakanan.Text = $"Rp. {totalMakanan}";
                labelTotalBayar.Text = $"Rp. {totalBayar}";
            }
            else if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnKurang"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                if ((OrderDetail)dataGridViewKeranjang.CurrentRow.DataBoundItem == null) return;
                OrderDetail detail = (OrderDetail)dataGridViewKeranjang.CurrentRow.DataBoundItem;
                if (detail.Amount > 1)
                {
                    detail.Amount -= 1;
                    detail.Total_price = detail.Amount * detail.Menu.Price;
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Hapus Menu dari Keranjang ?", "Hapus Menu",MessageBoxButtons.OKCancel);
                    if(dialog == DialogResult.OK)
                    {
                        keranjang.Remove(detail);
                    }
                }

                totalMakanan = 0;
                foreach (OrderDetail od in keranjang)
                {
                    totalMakanan += od.Total_price;
                }

                totalBayar = totalMakanan + ongkir;
                labelTotalMakanan.Text = $"Rp. {totalMakanan}";
                labelTotalBayar.Text = $"Rp. {totalBayar}";
            }
            else if(e.ColumnIndex == dataGridViewKeranjang.Columns["btnHapus"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                if ((OrderDetail)dataGridViewKeranjang.CurrentRow.DataBoundItem == null) return;
                OrderDetail detail = (OrderDetail)dataGridViewKeranjang.CurrentRow.DataBoundItem;
                DialogResult dialog = MessageBox.Show("Hapus Menu dari Keranjang ?", "Hapus Menu", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    keranjang.Remove(detail);
                }
                totalMakanan = 0;
                foreach (OrderDetail od in keranjang)
                {
                    totalMakanan += od.Total_price;
                }

                totalBayar = totalMakanan + ongkir;
                labelTotalMakanan.Text = $"Rp. {totalMakanan}";
                labelTotalBayar.Text = $"Rp. {totalBayar}";
            }
        }

        private void dataGridViewDaftarMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void numericUpDownLongitude_ValueChanged(object sender, EventArgs e)
        {
            double longitude = (double)numericUpDownLongitude.Value;
            double latitude = (double)numericUpDownLatitude.Value;

            if (longitude != 0 && latitude != 0)
            {
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
                ongkir = hitungOngkir;
                totalBayar = ongkir + totalMakanan;
                labelOngkosAntar.Text = $"Rp. {ongkir}";
                labelTotalBayar.Text = $"Rp. {totalBayar}";
            }
        }

        private void numericUpDownLatitude_ValueChanged(object sender, EventArgs e)
        {
            double longitude = (double)numericUpDownLongitude.Value;
            double latitude = (double)numericUpDownLatitude.Value;

            if(longitude != 0 && latitude != 0)
            {
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
                ongkir = hitungOngkir;
                totalBayar = ongkir + totalMakanan;
                labelOngkosAntar.Text = $"Rp. {ongkir}";
                labelTotalBayar.Text = $"Rp. {totalBayar}";
            }

        }
    }
}
