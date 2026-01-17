namespace UI_Baru_UAS
{
    partial class FormTopUp
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaldoSaatIni = new System.Windows.Forms.Label();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.buttonToUp = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(98, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(187, 38);
            this.lblGASLIVERY.TabIndex = 36;
            this.lblGASLIVERY.Text = "Top Up Saldo";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(13, 69);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(147, 22);
            this.labelUsername.TabIndex = 37;
            this.labelUsername.Text = "Saldo Saat Ini :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nominal Top Up :";
            // 
            // labelSaldoSaatIni
            // 
            this.labelSaldoSaatIni.AutoSize = true;
            this.labelSaldoSaatIni.BackColor = System.Drawing.Color.Transparent;
            this.labelSaldoSaatIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSaldoSaatIni.Location = new System.Drawing.Point(158, 69);
            this.labelSaldoSaatIni.Name = "labelSaldoSaatIni";
            this.labelSaldoSaatIni.Size = new System.Drawing.Size(46, 22);
            this.labelSaldoSaatIni.TabIndex = 39;
            this.labelSaldoSaatIni.Text = "Rp0";
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.Location = new System.Drawing.Point(182, 111);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(179, 22);
            this.textBoxNominal.TabIndex = 41;
            // 
            // buttonToUp
            // 
            this.buttonToUp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToUp.Location = new System.Drawing.Point(17, 158);
            this.buttonToUp.Name = "buttonToUp";
            this.buttonToUp.Size = new System.Drawing.Size(109, 51);
            this.buttonToUp.TabIndex = 42;
            this.buttonToUp.Text = "Top Up";
            this.buttonToUp.UseVisualStyleBackColor = true;
            this.buttonToUp.Click += new System.EventHandler(this.buttonToUp_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.Location = new System.Drawing.Point(252, 158);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(109, 51);
            this.buttonBatal.TabIndex = 43;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // FormTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 218);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonToUp);
            this.Controls.Add(this.textBoxNominal);
            this.Controls.Add(this.labelSaldoSaatIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormTopUp";
            this.Text = "FormTopUp";
            this.Load += new System.EventHandler(this.FormTopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaldoSaatIni;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.Button buttonToUp;
        private System.Windows.Forms.Button buttonBatal;
    }
}