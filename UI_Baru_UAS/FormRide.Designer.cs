namespace UI_Baru_UAS
{
    partial class FormRide
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
            this.buttonPesanRide = new System.Windows.Forms.Button();
            this.textBoxTitikTujuan = new System.Windows.Forms.TextBox();
            this.textBoxTitikJemput = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerJadwalkan = new System.Windows.Forms.DateTimePicker();
            this.radioButtonJadwalkan = new System.Windows.Forms.RadioButton();
            this.radioButtonSekarang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelJarak = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOngkos = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxDriverWanita = new System.Windows.Forms.CheckBox();
            this.checkBoxMotorBaru = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPesanRide
            // 
            this.buttonPesanRide.BackColor = System.Drawing.Color.Transparent;
            this.buttonPesanRide.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesanRide.Location = new System.Drawing.Point(18, 370);
            this.buttonPesanRide.Name = "buttonPesanRide";
            this.buttonPesanRide.Size = new System.Drawing.Size(132, 35);
            this.buttonPesanRide.TabIndex = 20;
            this.buttonPesanRide.Text = "Pesan Ride";
            this.buttonPesanRide.UseVisualStyleBackColor = false;
            // 
            // textBoxTitikTujuan
            // 
            this.textBoxTitikTujuan.Location = new System.Drawing.Point(142, 84);
            this.textBoxTitikTujuan.Name = "textBoxTitikTujuan";
            this.textBoxTitikTujuan.Size = new System.Drawing.Size(332, 22);
            this.textBoxTitikTujuan.TabIndex = 19;
            // 
            // textBoxTitikJemput
            // 
            this.textBoxTitikJemput.Location = new System.Drawing.Point(149, 52);
            this.textBoxTitikJemput.Name = "textBoxTitikJemput";
            this.textBoxTitikJemput.Size = new System.Drawing.Size(325, 22);
            this.textBoxTitikJemput.TabIndex = 18;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(147, 319);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 32);
            this.labelRole.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(12, 75);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(124, 32);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Titik Tujuan :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(12, 43);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(131, 32);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Titik Jemput :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(174, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(154, 38);
            this.lblGASLIVERY.TabIndex = 14;
            this.lblGASLIVERY.Text = "Pesan Ride";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerJadwalkan);
            this.groupBox1.Controls.Add(this.radioButtonJadwalkan);
            this.groupBox1.Controls.Add(this.radioButtonSekarang);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 66);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waktu Jemput";
            // 
            // dateTimePickerJadwalkan
            // 
            this.dateTimePickerJadwalkan.Location = new System.Drawing.Point(248, 27);
            this.dateTimePickerJadwalkan.Name = "dateTimePickerJadwalkan";
            this.dateTimePickerJadwalkan.Size = new System.Drawing.Size(200, 28);
            this.dateTimePickerJadwalkan.TabIndex = 2;
            // 
            // radioButtonJadwalkan
            // 
            this.radioButtonJadwalkan.AutoSize = true;
            this.radioButtonJadwalkan.Location = new System.Drawing.Point(123, 27);
            this.radioButtonJadwalkan.Name = "radioButtonJadwalkan";
            this.radioButtonJadwalkan.Size = new System.Drawing.Size(119, 24);
            this.radioButtonJadwalkan.TabIndex = 1;
            this.radioButtonJadwalkan.TabStop = true;
            this.radioButtonJadwalkan.Text = "Jadwalkan";
            this.radioButtonJadwalkan.UseVisualStyleBackColor = true;
            // 
            // radioButtonSekarang
            // 
            this.radioButtonSekarang.AutoSize = true;
            this.radioButtonSekarang.Location = new System.Drawing.Point(6, 27);
            this.radioButtonSekarang.Name = "radioButtonSekarang";
            this.radioButtonSekarang.Size = new System.Drawing.Size(111, 24);
            this.radioButtonSekarang.TabIndex = 0;
            this.radioButtonSekarang.TabStop = true;
            this.radioButtonSekarang.Text = "Sekarang";
            this.radioButtonSekarang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estimasi Biaya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Jarak :";
            // 
            // labelJarak
            // 
            this.labelJarak.AutoSize = true;
            this.labelJarak.BackColor = System.Drawing.Color.Transparent;
            this.labelJarak.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelJarak.Location = new System.Drawing.Point(87, 303);
            this.labelJarak.Name = "labelJarak";
            this.labelJarak.Size = new System.Drawing.Size(21, 32);
            this.labelJarak.TabIndex = 25;
            this.labelJarak.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ongkos :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(107, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 27;
            // 
            // labelOngkos
            // 
            this.labelOngkos.AutoSize = true;
            this.labelOngkos.BackColor = System.Drawing.Color.Transparent;
            this.labelOngkos.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOngkos.Location = new System.Drawing.Point(107, 335);
            this.labelOngkos.Name = "labelOngkos";
            this.labelOngkos.Size = new System.Drawing.Size(48, 32);
            this.labelOngkos.TabIndex = 28;
            this.labelOngkos.Text = "Rp0";
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(344, 370);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(132, 35);
            this.buttonBatal.TabIndex = 29;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Prefensi";
            // 
            // checkBoxDriverWanita
            // 
            this.checkBoxDriverWanita.AutoSize = true;
            this.checkBoxDriverWanita.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDriverWanita.Location = new System.Drawing.Point(18, 218);
            this.checkBoxDriverWanita.Name = "checkBoxDriverWanita";
            this.checkBoxDriverWanita.Size = new System.Drawing.Size(148, 24);
            this.checkBoxDriverWanita.TabIndex = 31;
            this.checkBoxDriverWanita.Text = "Driver Wanita";
            this.checkBoxDriverWanita.UseVisualStyleBackColor = true;
            // 
            // checkBoxMotorBaru
            // 
            this.checkBoxMotorBaru.AutoSize = true;
            this.checkBoxMotorBaru.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMotorBaru.Location = new System.Drawing.Point(18, 248);
            this.checkBoxMotorBaru.Name = "checkBoxMotorBaru";
            this.checkBoxMotorBaru.Size = new System.Drawing.Size(125, 24);
            this.checkBoxMotorBaru.TabIndex = 32;
            this.checkBoxMotorBaru.Text = "Motor Baru";
            this.checkBoxMotorBaru.UseVisualStyleBackColor = true;
            // 
            // FormRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 408);
            this.Controls.Add(this.checkBoxMotorBaru);
            this.Controls.Add(this.checkBoxDriverWanita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.labelOngkos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelJarak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPesanRide);
            this.Controls.Add(this.textBoxTitikTujuan);
            this.Controls.Add(this.textBoxTitikJemput);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormRide";
            this.Text = "FormRide";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPesanRide;
        private System.Windows.Forms.TextBox textBoxTitikTujuan;
        private System.Windows.Forms.TextBox textBoxTitikJemput;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerJadwalkan;
        private System.Windows.Forms.RadioButton radioButtonJadwalkan;
        private System.Windows.Forms.RadioButton radioButtonSekarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelJarak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOngkos;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxDriverWanita;
        private System.Windows.Forms.CheckBox checkBoxMotorBaru;
    }
}