namespace UI_Baru_UAS
{
    partial class FormTambahMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.numericUpDownHarga = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStok = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHalal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Halal: ";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(132, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(198, 38);
            this.lblGASLIVERY.TabIndex = 17;
            this.lblGASLIVERY.Text = "Tambah Menu";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(17, 249);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(192, 35);
            this.buttonTambah.TabIndex = 30;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(268, 249);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(190, 35);
            this.buttonBatal.TabIndex = 31;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(93, 76);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(313, 22);
            this.textBoxNama.TabIndex = 32;
            // 
            // numericUpDownHarga
            // 
            this.numericUpDownHarga.Location = new System.Drawing.Point(93, 114);
            this.numericUpDownHarga.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownHarga.Name = "numericUpDownHarga";
            this.numericUpDownHarga.Size = new System.Drawing.Size(151, 22);
            this.numericUpDownHarga.TabIndex = 36;
            // 
            // numericUpDownStok
            // 
            this.numericUpDownStok.Location = new System.Drawing.Point(93, 151);
            this.numericUpDownStok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStok.Name = "numericUpDownStok";
            this.numericUpDownStok.Size = new System.Drawing.Size(151, 22);
            this.numericUpDownStok.TabIndex = 37;
            // 
            // checkBoxHalal
            // 
            this.checkBoxHalal.AutoSize = true;
            this.checkBoxHalal.Location = new System.Drawing.Point(93, 193);
            this.checkBoxHalal.Name = "checkBoxHalal";
            this.checkBoxHalal.Size = new System.Drawing.Size(61, 20);
            this.checkBoxHalal.TabIndex = 38;
            this.checkBoxHalal.Text = "Halal";
            this.checkBoxHalal.UseVisualStyleBackColor = true;
            // 
            // FormTambahMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 293);
            this.Controls.Add(this.checkBoxHalal);
            this.Controls.Add(this.numericUpDownStok);
            this.Controls.Add(this.numericUpDownHarga);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahMenu";
            this.Text = "FormTambahMenu";
            this.Load += new System.EventHandler(this.FormTambahMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.NumericUpDown numericUpDownHarga;
        private System.Windows.Forms.NumericUpDown numericUpDownStok;
        private System.Windows.Forms.CheckBox checkBoxHalal;
    }
}