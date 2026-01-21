namespace UI_Baru_UAS
{
    partial class FormDetailPesanan
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
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelKonsumen = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelIDPesanan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dataGridViewDetailPesanan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.labelOngkosAntar = new System.Windows.Forms.Label();
            this.labelTotalPesanan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonVerifikasi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailPesanan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(294, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(203, 38);
            this.lblGASLIVERY.TabIndex = 9;
            this.lblGASLIVERY.Text = "Detail Pesanan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAlamat);
            this.groupBox1.Controls.Add(this.labelKonsumen);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labelTanggal);
            this.groupBox1.Controls.Add(this.labelIDPesanan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 193);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Pesanan";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.BackColor = System.Drawing.Color.Transparent;
            this.labelAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlamat.Location = new System.Drawing.Point(97, 152);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(85, 22);
            this.labelAlamat.TabIndex = 26;
            this.labelAlamat.Text = "(Alamat)";
            // 
            // labelKonsumen
            // 
            this.labelKonsumen.AutoSize = true;
            this.labelKonsumen.BackColor = System.Drawing.Color.Transparent;
            this.labelKonsumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKonsumen.Location = new System.Drawing.Point(126, 120);
            this.labelKonsumen.Name = "labelKonsumen";
            this.labelKonsumen.Size = new System.Drawing.Size(75, 22);
            this.labelKonsumen.TabIndex = 25;
            this.labelKonsumen.Text = "(Nama)";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatus.Location = new System.Drawing.Point(89, 88);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(196, 22);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "(Menunggu/selesai?)";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTanggal.Location = new System.Drawing.Point(103, 56);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(97, 22);
            this.labelTanggal.TabIndex = 23;
            this.labelTanggal.Text = "(Tanggal)";
            // 
            // labelIDPesanan
            // 
            this.labelIDPesanan.AutoSize = true;
            this.labelIDPesanan.BackColor = System.Drawing.Color.Transparent;
            this.labelIDPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelIDPesanan.Location = new System.Drawing.Point(130, 24);
            this.labelIDPesanan.Name = "labelIDPesanan";
            this.labelIDPesanan.Size = new System.Drawing.Size(40, 22);
            this.labelIDPesanan.TabIndex = 22;
            this.labelIDPesanan.Text = "(id)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Konsumen :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alamat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tanggal :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(6, 24);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(125, 22);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "ID Pesanan :";
            // 
            // dataGridViewDetailPesanan
            // 
            this.dataGridViewDetailPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailPesanan.Location = new System.Drawing.Point(361, 59);
            this.dataGridViewDetailPesanan.Name = "dataGridViewDetailPesanan";
            this.dataGridViewDetailPesanan.RowHeadersWidth = 51;
            this.dataGridViewDetailPesanan.RowTemplate.Height = 24;
            this.dataGridViewDetailPesanan.Size = new System.Drawing.Size(427, 349);
            this.dataGridViewDetailPesanan.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTotalBayar);
            this.groupBox2.Controls.Add(this.labelDiskon);
            this.groupBox2.Controls.Add(this.labelOngkosAntar);
            this.groupBox2.Controls.Add(this.labelTotalPesanan);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 159);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RIngkasan";
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalBayar.Location = new System.Drawing.Point(132, 120);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(46, 22);
            this.labelTotalBayar.TabIndex = 25;
            this.labelTotalBayar.Text = "Rp0";
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.BackColor = System.Drawing.Color.Transparent;
            this.labelDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDiskon.Location = new System.Drawing.Point(89, 88);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(46, 22);
            this.labelDiskon.TabIndex = 24;
            this.labelDiskon.Text = "Rp0";
            // 
            // labelOngkosAntar
            // 
            this.labelOngkosAntar.AutoSize = true;
            this.labelOngkosAntar.BackColor = System.Drawing.Color.Transparent;
            this.labelOngkosAntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOngkosAntar.Location = new System.Drawing.Point(153, 56);
            this.labelOngkosAntar.Name = "labelOngkosAntar";
            this.labelOngkosAntar.Size = new System.Drawing.Size(46, 22);
            this.labelOngkosAntar.TabIndex = 23;
            this.labelOngkosAntar.Text = "Rp0";
            // 
            // labelTotalPesanan
            // 
            this.labelTotalPesanan.AutoSize = true;
            this.labelTotalPesanan.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalPesanan.Location = new System.Drawing.Point(163, 24);
            this.labelTotalPesanan.Name = "labelTotalPesanan";
            this.labelTotalPesanan.Size = new System.Drawing.Size(46, 22);
            this.labelTotalPesanan.TabIndex = 22;
            this.labelTotalPesanan.Text = "Rp0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(6, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Bayar :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Diskon :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ongkos Antar :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "Total makanan :";
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(19, 414);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(228, 46);
            this.buttonTutup.TabIndex = 28;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // buttonRating
            // 
            this.buttonRating.BackColor = System.Drawing.Color.Transparent;
            this.buttonRating.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRating.Location = new System.Drawing.Point(253, 414);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(260, 46);
            this.buttonRating.TabIndex = 29;
            this.buttonRating.Text = "Rating";
            this.buttonRating.UseVisualStyleBackColor = false;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // buttonVerifikasi
            // 
            this.buttonVerifikasi.BackColor = System.Drawing.Color.Transparent;
            this.buttonVerifikasi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerifikasi.Location = new System.Drawing.Point(525, 414);
            this.buttonVerifikasi.Name = "buttonVerifikasi";
            this.buttonVerifikasi.Size = new System.Drawing.Size(263, 46);
            this.buttonVerifikasi.TabIndex = 30;
            this.buttonVerifikasi.Text = "Verifikasi";
            this.buttonVerifikasi.UseVisualStyleBackColor = false;
            this.buttonVerifikasi.Click += new System.EventHandler(this.buttonVerifikasi_Click);
            // 
            // FormDetailPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.buttonVerifikasi);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewDetailPesanan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormDetailPesanan";
            this.Text = "FormDetailPesanan";
            this.Load += new System.EventHandler(this.FormDetailPesanan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailPesanan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelIDPesanan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelKonsumen;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DataGridView dataGridViewDetailPesanan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelOngkosAntar;
        private System.Windows.Forms.Label labelTotalPesanan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.Button buttonVerifikasi;
    }
}