namespace UI_Baru_UAS
{
    partial class FormFood
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
            this.buttonPesanFood = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.comboBoxPilihTenan = new System.Windows.Forms.ComboBox();
            this.dataGridViewDaftarMenu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMenuHalal = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOngkosAntar = new System.Windows.Forms.Label();
            this.labelTotalMakanan = new System.Windows.Forms.Label();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownLongitude = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLatitude = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPesanFood
            // 
            this.buttonPesanFood.BackColor = System.Drawing.Color.Transparent;
            this.buttonPesanFood.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesanFood.Location = new System.Drawing.Point(19, 453);
            this.buttonPesanFood.Name = "buttonPesanFood";
            this.buttonPesanFood.Size = new System.Drawing.Size(454, 48);
            this.buttonPesanFood.TabIndex = 20;
            this.buttonPesanFood.Text = "Pesan Food";
            this.buttonPesanFood.UseVisualStyleBackColor = false;
            this.buttonPesanFood.Click += new System.EventHandler(this.buttonPesanFood_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(132, 336);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(341, 22);
            this.textBoxPassword.TabIndex = 19;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(257, 153);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 22);
            this.labelRole.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(13, 334);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 22);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Titik Antar :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(13, 55);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(124, 22);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Pilih Tenan :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(412, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(162, 38);
            this.lblGASLIVERY.TabIndex = 14;
            this.lblGASLIVERY.Text = "Pesan Food";
            // 
            // comboBoxPilihTenan
            // 
            this.comboBoxPilihTenan.FormattingEnabled = true;
            this.comboBoxPilihTenan.Location = new System.Drawing.Point(136, 55);
            this.comboBoxPilihTenan.Name = "comboBoxPilihTenan";
            this.comboBoxPilihTenan.Size = new System.Drawing.Size(337, 24);
            this.comboBoxPilihTenan.TabIndex = 21;
            this.comboBoxPilihTenan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPilihTenan_SelectedIndexChanged);
            // 
            // dataGridViewDaftarMenu
            // 
            this.dataGridViewDaftarMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarMenu.Location = new System.Drawing.Point(19, 118);
            this.dataGridViewDaftarMenu.Name = "dataGridViewDaftarMenu";
            this.dataGridViewDaftarMenu.RowHeadersWidth = 51;
            this.dataGridViewDaftarMenu.RowTemplate.Height = 24;
            this.dataGridViewDaftarMenu.Size = new System.Drawing.Size(454, 172);
            this.dataGridViewDaftarMenu.TabIndex = 22;
            this.dataGridViewDaftarMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarMenu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Daftar Menu";
            // 
            // checkBoxMenuHalal
            // 
            this.checkBoxMenuHalal.AutoSize = true;
            this.checkBoxMenuHalal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMenuHalal.Location = new System.Drawing.Point(19, 296);
            this.checkBoxMenuHalal.Name = "checkBoxMenuHalal";
            this.checkBoxMenuHalal.Size = new System.Drawing.Size(279, 24);
            this.checkBoxMenuHalal.TabIndex = 32;
            this.checkBoxMenuHalal.Text = "Hanya tampilkan menu halal";
            this.checkBoxMenuHalal.UseVisualStyleBackColor = true;
            this.checkBoxMenuHalal.CheckedChanged += new System.EventHandler(this.checkBoxMenuHalal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Estimasi Biaya ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ongkos Antar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Biaya Makanan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total Bayar :";
            // 
            // labelOngkosAntar
            // 
            this.labelOngkosAntar.AutoSize = true;
            this.labelOngkosAntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOngkosAntar.Location = new System.Drawing.Point(654, 347);
            this.labelOngkosAntar.Name = "labelOngkosAntar";
            this.labelOngkosAntar.Size = new System.Drawing.Size(46, 22);
            this.labelOngkosAntar.TabIndex = 37;
            this.labelOngkosAntar.Text = "Rp0";
            // 
            // labelTotalMakanan
            // 
            this.labelTotalMakanan.AutoSize = true;
            this.labelTotalMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMakanan.Location = new System.Drawing.Point(663, 379);
            this.labelTotalMakanan.Name = "labelTotalMakanan";
            this.labelTotalMakanan.Size = new System.Drawing.Size(46, 22);
            this.labelTotalMakanan.TabIndex = 38;
            this.labelTotalMakanan.Text = "Rp0";
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBayar.Location = new System.Drawing.Point(633, 411);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(46, 22);
            this.labelTotalBayar.TabIndex = 39;
            this.labelTotalBayar.Text = "Rp0";
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(511, 453);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(454, 48);
            this.buttonBatal.TabIndex = 40;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Longitude :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Latitude :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(700, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 47;
            this.label8.Text = "Keranjang";
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(511, 118);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(454, 172);
            this.dataGridViewKeranjang.TabIndex = 46;
            this.dataGridViewKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(801, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 45;
            // 
            // numericUpDownLongitude
            // 
            this.numericUpDownLongitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDownLongitude.Location = new System.Drawing.Point(132, 373);
            this.numericUpDownLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numericUpDownLongitude.Name = "numericUpDownLongitude";
            this.numericUpDownLongitude.Size = new System.Drawing.Size(341, 22);
            this.numericUpDownLongitude.TabIndex = 48;
            // 
            // numericUpDownLatitude
            // 
            this.numericUpDownLatitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDownLatitude.Location = new System.Drawing.Point(132, 406);
            this.numericUpDownLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numericUpDownLatitude.Name = "numericUpDownLatitude";
            this.numericUpDownLatitude.Size = new System.Drawing.Size(341, 22);
            this.numericUpDownLatitude.TabIndex = 49;
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 515);
            this.Controls.Add(this.numericUpDownLatitude);
            this.Controls.Add(this.numericUpDownLongitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.labelTotalBayar);
            this.Controls.Add(this.labelTotalMakanan);
            this.Controls.Add(this.labelOngkosAntar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxMenuHalal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDaftarMenu);
            this.Controls.Add(this.comboBoxPilihTenan);
            this.Controls.Add(this.buttonPesanFood);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormFood";
            this.Text = "FormFood";
            this.Load += new System.EventHandler(this.FormFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPesanFood;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.ComboBox comboBoxPilihTenan;
        private System.Windows.Forms.DataGridView dataGridViewDaftarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMenuHalal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOngkosAntar;
        private System.Windows.Forms.Label labelTotalMakanan;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownLongitude;
        private System.Windows.Forms.NumericUpDown numericUpDownLatitude;
    }
}