namespace UI_Baru_UAS
{
    partial class FormUbahKendaraan
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
            this.textBoxMerk = new System.Windows.Forms.TextBox();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBeli = new System.Windows.Forms.DateTimePicker();
            this.textBoxPlat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMerk
            // 
            this.textBoxMerk.Location = new System.Drawing.Point(143, 70);
            this.textBoxMerk.Name = "textBoxMerk";
            this.textBoxMerk.Size = new System.Drawing.Size(313, 22);
            this.textBoxMerk.TabIndex = 55;
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(291, 207);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(190, 35);
            this.buttonBatal.TabIndex = 54;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Transparent;
            this.buttonUbah.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.Location = new System.Drawing.Point(36, 207);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(192, 35);
            this.buttonUbah.TabIndex = 53;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(146, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(229, 38);
            this.lblGASLIVERY.TabIndex = 52;
            this.lblGASLIVERY.Text = "Ubah Kendaraan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tanggal Beli: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Plat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Merk: ";
            // 
            // dateTimePickerBeli
            // 
            this.dateTimePickerBeli.Location = new System.Drawing.Point(143, 146);
            this.dateTimePickerBeli.Name = "dateTimePickerBeli";
            this.dateTimePickerBeli.Size = new System.Drawing.Size(313, 22);
            this.dateTimePickerBeli.TabIndex = 58;
            // 
            // textBoxPlat
            // 
            this.textBoxPlat.Location = new System.Drawing.Point(143, 111);
            this.textBoxPlat.Name = "textBoxPlat";
            this.textBoxPlat.Size = new System.Drawing.Size(313, 22);
            this.textBoxPlat.TabIndex = 59;
            // 
            // FormUbahKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.textBoxPlat);
            this.Controls.Add(this.dateTimePickerBeli);
            this.Controls.Add(this.textBoxMerk);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUbahKendaraan";
            this.Text = "FormUbahKendaraan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMerk;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeli;
        private System.Windows.Forms.TextBox textBoxPlat;
    }
}