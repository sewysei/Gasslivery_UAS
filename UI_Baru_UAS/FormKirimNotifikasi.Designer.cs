namespace UI_Baru_UAS
{
    partial class FormKirimNotifikasi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSemuaDriver = new System.Windows.Forms.RadioButton();
            this.radioButtonDriverTertentu = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(100, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(211, 38);
            this.lblGASLIVERY.TabIndex = 29;
            this.lblGASLIVERY.Text = "Kirim Notifikasi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.radioButtonDriverTertentu);
            this.groupBox2.Controls.Add(this.radioButtonSemuaDriver);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 101);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tujuan";
            // 
            // radioButtonSemuaDriver
            // 
            this.radioButtonSemuaDriver.AutoSize = true;
            this.radioButtonSemuaDriver.Location = new System.Drawing.Point(6, 27);
            this.radioButtonSemuaDriver.Name = "radioButtonSemuaDriver";
            this.radioButtonSemuaDriver.Size = new System.Drawing.Size(148, 24);
            this.radioButtonSemuaDriver.TabIndex = 0;
            this.radioButtonSemuaDriver.TabStop = true;
            this.radioButtonSemuaDriver.Text = "Semua Driver";
            this.radioButtonSemuaDriver.UseVisualStyleBackColor = true;
            // 
            // radioButtonDriverTertentu
            // 
            this.radioButtonDriverTertentu.AutoSize = true;
            this.radioButtonDriverTertentu.Location = new System.Drawing.Point(6, 57);
            this.radioButtonDriverTertentu.Name = "radioButtonDriverTertentu";
            this.radioButtonDriverTertentu.Size = new System.Drawing.Size(173, 24);
            this.radioButtonDriverTertentu.TabIndex = 1;
            this.radioButtonDriverTertentu.TabStop = true;
            this.radioButtonDriverTertentu.Text = "Driver Tertentu :";
            this.radioButtonDriverTertentu.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 65);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 28);
            this.textBox1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(11, 225);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 32);
            this.labelUsername.TabIndex = 32;
            this.labelUsername.Text = "Tanggal :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.BackColor = System.Drawing.Color.Transparent;
            this.labelTanggal.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTanggal.Location = new System.Drawing.Point(108, 225);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(46, 32);
            this.labelTanggal.TabIndex = 33;
            this.labelTanggal.Text = "(....)";
            // 
            // buttonKirim
            // 
            this.buttonKirim.BackColor = System.Drawing.Color.Transparent;
            this.buttonKirim.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKirim.Location = new System.Drawing.Point(11, 260);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(132, 35);
            this.buttonKirim.TabIndex = 34;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(264, 260);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(132, 35);
            this.buttonTutup.TabIndex = 35;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // FormKirimNotifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 313);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormKirimNotifikasi";
            this.Text = "FormKirimNotifikasi";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDriverTertentu;
        private System.Windows.Forms.RadioButton radioButtonSemuaDriver;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.Button buttonTutup;
    }
}