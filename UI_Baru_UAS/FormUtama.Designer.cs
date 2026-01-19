namespace UI_Baru_UAS
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesanRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesanFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatTopUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terimaOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarikDanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatTarikDanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelolaMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesananMasukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringKendaraanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirimNotifikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelLoginSebagai = new System.Windows.Forms.Label();
            this.notifikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rideToolStripMenuItem,
            this.foodToolStripMenuItem,
            this.saldoToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.tenanToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.akunToolStripMenuItem,
            this.voucherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rideToolStripMenuItem
            // 
            this.rideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesanRideToolStripMenuItem,
            this.riwayatRideToolStripMenuItem});
            this.rideToolStripMenuItem.Name = "rideToolStripMenuItem";
            this.rideToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.rideToolStripMenuItem.Text = "Ride";
            // 
            // pesanRideToolStripMenuItem
            // 
            this.pesanRideToolStripMenuItem.Name = "pesanRideToolStripMenuItem";
            this.pesanRideToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.pesanRideToolStripMenuItem.Text = "Pesan Ride";
            this.pesanRideToolStripMenuItem.Click += new System.EventHandler(this.pesanRideToolStripMenuItem_Click);
            // 
            // riwayatRideToolStripMenuItem
            // 
            this.riwayatRideToolStripMenuItem.Name = "riwayatRideToolStripMenuItem";
            this.riwayatRideToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.riwayatRideToolStripMenuItem.Text = "Riwayat Ride";
            this.riwayatRideToolStripMenuItem.Click += new System.EventHandler(this.riwayatRideToolStripMenuItem_Click);
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesanFoodToolStripMenuItem,
            this.riwayatFoodToolStripMenuItem});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.foodToolStripMenuItem.Text = "Food";
            // 
            // pesanFoodToolStripMenuItem
            // 
            this.pesanFoodToolStripMenuItem.Name = "pesanFoodToolStripMenuItem";
            this.pesanFoodToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pesanFoodToolStripMenuItem.Text = "Pesan Food";
            this.pesanFoodToolStripMenuItem.Click += new System.EventHandler(this.pesanFoodToolStripMenuItem_Click);
            // 
            // riwayatFoodToolStripMenuItem
            // 
            this.riwayatFoodToolStripMenuItem.Name = "riwayatFoodToolStripMenuItem";
            this.riwayatFoodToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.riwayatFoodToolStripMenuItem.Text = "Riwayat Food";
            this.riwayatFoodToolStripMenuItem.Click += new System.EventHandler(this.riwayatFoodToolStripMenuItem_Click);
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topUpToolStripMenuItem,
            this.riwayatTopUpToolStripMenuItem});
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.saldoToolStripMenuItem.Text = "Saldo";
            // 
            // topUpToolStripMenuItem
            // 
            this.topUpToolStripMenuItem.Name = "topUpToolStripMenuItem";
            this.topUpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.topUpToolStripMenuItem.Text = "Top Up";
            this.topUpToolStripMenuItem.Click += new System.EventHandler(this.topUpToolStripMenuItem_Click);
            // 
            // riwayatTopUpToolStripMenuItem
            // 
            this.riwayatTopUpToolStripMenuItem.Name = "riwayatTopUpToolStripMenuItem";
            this.riwayatTopUpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.riwayatTopUpToolStripMenuItem.Text = "Riwayat Top Up";
            this.riwayatTopUpToolStripMenuItem.Click += new System.EventHandler(this.riwayatTopUpToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terimaOrderToolStripMenuItem,
            this.riwayatTripToolStripMenuItem,
            this.tarikDanaToolStripMenuItem,
            this.riwayatTarikDanaToolStripMenuItem,
            this.notifikasiToolStripMenuItem});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // terimaOrderToolStripMenuItem
            // 
            this.terimaOrderToolStripMenuItem.Name = "terimaOrderToolStripMenuItem";
            this.terimaOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.terimaOrderToolStripMenuItem.Text = "Terima Order";
            this.terimaOrderToolStripMenuItem.Click += new System.EventHandler(this.terimaOrderToolStripMenuItem_Click);
            // 
            // riwayatTripToolStripMenuItem
            // 
            this.riwayatTripToolStripMenuItem.Name = "riwayatTripToolStripMenuItem";
            this.riwayatTripToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.riwayatTripToolStripMenuItem.Text = "Riwayat Trip";
            this.riwayatTripToolStripMenuItem.Click += new System.EventHandler(this.riwayatTripToolStripMenuItem_Click);
            // 
            // tarikDanaToolStripMenuItem
            // 
            this.tarikDanaToolStripMenuItem.Name = "tarikDanaToolStripMenuItem";
            this.tarikDanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tarikDanaToolStripMenuItem.Text = "Tarik Dana";
            this.tarikDanaToolStripMenuItem.Click += new System.EventHandler(this.tarikDanaToolStripMenuItem_Click);
            // 
            // riwayatTarikDanaToolStripMenuItem
            // 
            this.riwayatTarikDanaToolStripMenuItem.Name = "riwayatTarikDanaToolStripMenuItem";
            this.riwayatTarikDanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.riwayatTarikDanaToolStripMenuItem.Text = "Riwayat Tarik Dana";
            this.riwayatTarikDanaToolStripMenuItem.Click += new System.EventHandler(this.riwayatTarikDanaToolStripMenuItem_Click);
            // 
            // tenanToolStripMenuItem
            // 
            this.tenanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelolaMenuToolStripMenuItem,
            this.pesananMasukToolStripMenuItem,
            this.riwayatPenjualanToolStripMenuItem});
            this.tenanToolStripMenuItem.Name = "tenanToolStripMenuItem";
            this.tenanToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.tenanToolStripMenuItem.Text = "Tenan";
            // 
            // kelolaMenuToolStripMenuItem
            // 
            this.kelolaMenuToolStripMenuItem.Name = "kelolaMenuToolStripMenuItem";
            this.kelolaMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kelolaMenuToolStripMenuItem.Text = "Kelola Menu";
            this.kelolaMenuToolStripMenuItem.Click += new System.EventHandler(this.kelolaMenuToolStripMenuItem_Click);
            // 
            // pesananMasukToolStripMenuItem
            // 
            this.pesananMasukToolStripMenuItem.Name = "pesananMasukToolStripMenuItem";
            this.pesananMasukToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pesananMasukToolStripMenuItem.Text = "Pesanan Masuk";
            this.pesananMasukToolStripMenuItem.Click += new System.EventHandler(this.pesananMasukToolStripMenuItem_Click);
            // 
            // riwayatPenjualanToolStripMenuItem
            // 
            this.riwayatPenjualanToolStripMenuItem.Name = "riwayatPenjualanToolStripMenuItem";
            this.riwayatPenjualanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.riwayatPenjualanToolStripMenuItem.Text = "Riwayat Penjualan";
            this.riwayatPenjualanToolStripMenuItem.Click += new System.EventHandler(this.riwayatPenjualanToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanTransaksiToolStripMenuItem,
            this.laporanCancelToolStripMenuItem,
            this.laporanReportToolStripMenuItem,
            this.monitoringDriverToolStripMenuItem,
            this.monitoringKendaraanToolStripMenuItem,
            this.kirimNotifikasiToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // laporanTransaksiToolStripMenuItem
            // 
            this.laporanTransaksiToolStripMenuItem.Name = "laporanTransaksiToolStripMenuItem";
            this.laporanTransaksiToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.laporanTransaksiToolStripMenuItem.Text = "Laporan Transaksi";
            this.laporanTransaksiToolStripMenuItem.Click += new System.EventHandler(this.laporanTransaksiToolStripMenuItem_Click);
            // 
            // laporanCancelToolStripMenuItem
            // 
            this.laporanCancelToolStripMenuItem.Name = "laporanCancelToolStripMenuItem";
            this.laporanCancelToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.laporanCancelToolStripMenuItem.Text = "Laporan Cancel";
            this.laporanCancelToolStripMenuItem.Click += new System.EventHandler(this.laporanCancelToolStripMenuItem_Click);
            // 
            // laporanReportToolStripMenuItem
            // 
            this.laporanReportToolStripMenuItem.Name = "laporanReportToolStripMenuItem";
            this.laporanReportToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.laporanReportToolStripMenuItem.Text = "Laporan Report";
            this.laporanReportToolStripMenuItem.Click += new System.EventHandler(this.laporanReportToolStripMenuItem_Click);
            // 
            // monitoringDriverToolStripMenuItem
            // 
            this.monitoringDriverToolStripMenuItem.Name = "monitoringDriverToolStripMenuItem";
            this.monitoringDriverToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.monitoringDriverToolStripMenuItem.Text = "Monitoring Driver";
            this.monitoringDriverToolStripMenuItem.Click += new System.EventHandler(this.monitoringDriverToolStripMenuItem_Click);
            // 
            // monitoringKendaraanToolStripMenuItem
            // 
            this.monitoringKendaraanToolStripMenuItem.Name = "monitoringKendaraanToolStripMenuItem";
            this.monitoringKendaraanToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.monitoringKendaraanToolStripMenuItem.Text = "Monitoring Kendaraan";
            this.monitoringKendaraanToolStripMenuItem.Click += new System.EventHandler(this.monitoringKendaraanToolStripMenuItem_Click);
            // 
            // kirimNotifikasiToolStripMenuItem
            // 
            this.kirimNotifikasiToolStripMenuItem.Name = "kirimNotifikasiToolStripMenuItem";
            this.kirimNotifikasiToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.kirimNotifikasiToolStripMenuItem.Text = "Kirim Notifikasi";
            this.kirimNotifikasiToolStripMenuItem.Click += new System.EventHandler(this.kirimNotifikasiToolStripMenuItem_Click);
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.akunToolStripMenuItem.Text = "Akun";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // voucherToolStripMenuItem
            // 
            this.voucherToolStripMenuItem.Name = "voucherToolStripMenuItem";
            this.voucherToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.voucherToolStripMenuItem.Text = "Voucher";
            this.voucherToolStripMenuItem.Click += new System.EventHandler(this.voucherToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelLoginSebagai
            // 
            this.labelLoginSebagai.AutoSize = true;
            this.labelLoginSebagai.Location = new System.Drawing.Point(693, 9);
            this.labelLoginSebagai.Name = "labelLoginSebagai";
            this.labelLoginSebagai.Size = new System.Drawing.Size(95, 16);
            this.labelLoginSebagai.TabIndex = 2;
            this.labelLoginSebagai.Text = "Login Sebagai";
            // 
            // notifikasiToolStripMenuItem
            // 
            this.notifikasiToolStripMenuItem.Name = "notifikasiToolStripMenuItem";
            this.notifikasiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notifikasiToolStripMenuItem.Text = "Notifikasi";
            this.notifikasiToolStripMenuItem.Click += new System.EventHandler(this.notifikasiToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoginSebagai);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesanRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesanFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatTopUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terimaOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarikDanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatTarikDanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelolaMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesananMasukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringKendaraanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirimNotifikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label labelLoginSebagai;
        private System.Windows.Forms.ToolStripMenuItem voucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifikasiToolStripMenuItem;
    }
}

