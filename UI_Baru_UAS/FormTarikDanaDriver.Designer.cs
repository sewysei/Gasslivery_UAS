namespace UI_Baru_UAS
{
    partial class FormTarikDanaDriver
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaldoSaatIni = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitikJemput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTarikDana = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(102, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(150, 38);
            this.lblGASLIVERY.TabIndex = 16;
            this.lblGASLIVERY.Text = "Tarik Dana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Saldo Saat Ini :";
            // 
            // labelSaldoSaatIni
            // 
            this.labelSaldoSaatIni.AutoSize = true;
            this.labelSaldoSaatIni.BackColor = System.Drawing.Color.Transparent;
            this.labelSaldoSaatIni.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSaldoSaatIni.Location = new System.Drawing.Point(158, 47);
            this.labelSaldoSaatIni.Name = "labelSaldoSaatIni";
            this.labelSaldoSaatIni.Size = new System.Drawing.Size(48, 32);
            this.labelSaldoSaatIni.TabIndex = 38;
            this.labelSaldoSaatIni.Text = "Rp0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Jumlah Penarikan :\r\n";
            // 
            // textBoxTitikJemput
            // 
            this.textBoxTitikJemput.Location = new System.Drawing.Point(195, 89);
            this.textBoxTitikJemput.Name = "textBoxTitikJemput";
            this.textBoxTitikJemput.Size = new System.Drawing.Size(160, 22);
            this.textBoxTitikJemput.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "Minimal Penarikan Dana Rp50,000";
            // 
            // buttonTarikDana
            // 
            this.buttonTarikDana.BackColor = System.Drawing.Color.Transparent;
            this.buttonTarikDana.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTarikDana.Location = new System.Drawing.Point(12, 158);
            this.buttonTarikDana.Name = "buttonTarikDana";
            this.buttonTarikDana.Size = new System.Drawing.Size(158, 35);
            this.buttonTarikDana.TabIndex = 44;
            this.buttonTarikDana.Text = "Tarik Dana";
            this.buttonTarikDana.UseVisualStyleBackColor = false;
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Transparent;
            this.buttonBatal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(223, 158);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(132, 35);
            this.buttonBatal.TabIndex = 45;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = false;
            // 
            // FormTarikDanaDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 208);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonTarikDana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitikJemput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSaldoSaatIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormTarikDanaDriver";
            this.Text = "FormTarikDanaDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaldoSaatIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitikJemput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTarikDana;
        private System.Windows.Forms.Button buttonBatal;
    }
}