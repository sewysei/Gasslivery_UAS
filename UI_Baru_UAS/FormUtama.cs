using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Gasslivery;

namespace UI_Baru_UAS
{
    public partial class FormUtama : Form
    {
        public User userLogin;
        public Admin adminLogin;
        public Consumer consumerLogin;
        public Driver driverLogin;
        public Tenant tenantLogin;
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();

            if (userLogin is null)
            {
                this.Close();
            }
            else
            {
                this.Show();
                labelLoginSebagai.Text = $"{userLogin.Role}";

                if (userLogin.Role == "consumer")
                {
                    // Gunakan ID dari users untuk mencari consumer (one-to-one relationship)
                    consumerLogin = Consumer.CekLoginById(userLogin.Id);
                    // Fallback: jika tidak ditemukan dengan ID, coba dengan username
                    if (consumerLogin == null)
                    {
                        consumerLogin = Consumer.CekLogin(userLogin.Username, userLogin.Password);
                    }
                    driverToolStripMenuItem.Visible = false;
                    tenanToolStripMenuItem.Visible = false;
                    adminToolStripMenuItem.Visible = false;
                }
                else if (userLogin.Role == "admin")
                {
                    adminLogin = Admin.CekLogin(userLogin.Username, userLogin.Password);
                    rideToolStripMenuItem.Visible = false;
                    foodToolStripMenuItem.Visible = false;
                    saldoToolStripMenuItem.Visible = false;
                    driverToolStripMenuItem.Visible = false;
                    tenanToolStripMenuItem.Visible = false;
                }
                else if (userLogin.Role == "driver")
                {
                    driverLogin = Driver.CekLogin(userLogin.Username, userLogin.Password);
                    rideToolStripMenuItem.Visible = false;
                    foodToolStripMenuItem.Visible = false;
                    saldoToolStripMenuItem.Visible = false;
                    adminToolStripMenuItem.Visible = false;
                    tenanToolStripMenuItem.Visible = false;
                }
                else if (userLogin.Role == "tenant")
                {
                    tenantLogin = Tenant.CekLogin(userLogin.Username, userLogin.Password);
                    rideToolStripMenuItem.Visible = false;
                    foodToolStripMenuItem.Visible = false;
                    saldoToolStripMenuItem.Visible = false;
                    adminToolStripMenuItem.Visible = false;
                    driverToolStripMenuItem.Visible = false;
                }
            }
        }

        private void pesanRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRide"];
            if (frm == null)
            {
                FormRide form = new FormRide(this);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void riwayatRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatRide"];
            if (frm == null)
            {
                FormRiwayatRide form = new FormRiwayatRide(this);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void pesanFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormFood"];
            if (frm == null)
            {
                FormFood form = new FormFood();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void riwayatFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatFood"];
            if (frm == null)
            {
                FormRiwayatFood form = new FormRiwayatFood();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void topUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormTopUp"];
            if (frm == null)
            {
                FormTopUp form = new FormTopUp();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void riwayatTopUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatTopUp"];
            if (frm == null)
            {
                FormRiwayatTopUp form = new FormRiwayatTopUp();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void terimaOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormTerimaOrder"];
            if (frm == null)
            {
                FormTerimaOrder form = new FormTerimaOrder();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void riwayatTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatRide"];
            if (frm == null)
            {
                FormRiwayatRide form = new FormRiwayatRide(this);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void tarikDanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormTarikDanaDriver"];
            if (frm == null)
            {
                FormTarikDanaDriver form = new FormTarikDanaDriver();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void riwayatTarikDanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatTarikDana"];
            if (frm == null)
            {
                FormRiwayatTarikDana form = new FormRiwayatTarikDana();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kelolaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormKelolaMenu"];
            if (frm == null)
            {
                FormKelolaMenu form = new FormKelolaMenu(this);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void pesananMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatFood"];
            if (frm == null)
            {
                FormPesananMasuk form = new FormPesananMasuk(this);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void riwayatPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormRiwayatPenjualan"];
            if (frm == null)
            {
                FormRiwayatPenjualan form = new FormRiwayatPenjualan();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void laporanTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormLaporanTransaksi"];
            if (frm == null)
            {
                FormLaporanTransaksi form = new FormLaporanTransaksi();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void laporanCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormLaporanCancel"];
            if (frm == null)
            {
                FormLaporanCancel form = new FormLaporanCancel();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void laporanReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormLaporanReport"];
            if (frm == null)
            {
                FormLaporanReport form = new FormLaporanReport(this);
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void monitoringDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormMonitoringDriver"];
            if (frm == null)
            {
                FormMonitoringDriver form = new FormMonitoringDriver();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void monitoringKendaraanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormMonitoringKendaraan"];
            if (frm == null)
            {
                FormMonitoringKendaraan form = new FormMonitoringKendaraan();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void kirimNotifikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormKirimNotifikasi"];
            if (frm == null)
            {
                FormKirimNotifikasi form = new FormKirimNotifikasi();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();

            if (userLogin is null)
            {
                this.Close();
            }
            else
            {
                this.Show();
                labelLoginSebagai.Text = $"{userLogin.Role}";

                if (userLogin.Role == "consumer")
                {
                    // Gunakan ID dari users untuk mencari consumer (one-to-one relationship)
                    consumerLogin = Consumer.CekLoginById(userLogin.Id);
                    // Fallback: jika tidak ditemukan dengan ID, coba dengan username
                    if (consumerLogin == null)
                    {
                        consumerLogin = Consumer.CekLogin(userLogin.Username, userLogin.Password);
                    }
                    driverToolStripMenuItem.Visible = false;
                    tenanToolStripMenuItem.Visible = false;
                    adminToolStripMenuItem.Visible = false;
                }
                else if (userLogin.Role == "admin")
                {
                    adminLogin = Admin.CekLogin(userLogin.Username, userLogin.Password);
                    rideToolStripMenuItem.Visible = false;
                    foodToolStripMenuItem.Visible = false;
                    saldoToolStripMenuItem.Visible = false;
                    driverToolStripMenuItem.Visible = false;
                    tenanToolStripMenuItem.Visible = false;
                }
                else if (userLogin.Role == "driver")
                {
                    driverLogin = Driver.CekLogin(userLogin.Username, userLogin.Password);
                    rideToolStripMenuItem.Visible = false;
                    foodToolStripMenuItem.Visible = false;
                    saldoToolStripMenuItem.Visible = false;
                    adminToolStripMenuItem.Visible = false;
                    tenanToolStripMenuItem.Visible = false;
                }
                else if (userLogin.Role == "tenant")
                {
                    tenantLogin = Tenant.CekLogin(userLogin.Username, userLogin.Password);
                    rideToolStripMenuItem.Visible = false;
                    foodToolStripMenuItem.Visible = false;
                    saldoToolStripMenuItem.Visible = false;
                    adminToolStripMenuItem.Visible = false;
                    driverToolStripMenuItem.Visible = false;
                }
            }
        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FormVoucher"];
            if (frm == null)
            {
                FormVoucher form = new FormVoucher();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                frm.Show();
                frm.BringToFront();
            }
        }
    }
}
