namespace UI_Baru_UAS
{
    partial class FormPesananMasuk
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
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonTerima = new System.Windows.Forms.Button();
            this.dataGridViewPesananMasuk = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.buttonTolak = new System.Windows.Forms.Button();
            this.buttonLihatDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesananMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(666, 362);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 34;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // buttonTerima
            // 
            this.buttonTerima.BackColor = System.Drawing.Color.Transparent;
            this.buttonTerima.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerima.Location = new System.Drawing.Point(12, 361);
            this.buttonTerima.Name = "buttonTerima";
            this.buttonTerima.Size = new System.Drawing.Size(114, 35);
            this.buttonTerima.TabIndex = 32;
            this.buttonTerima.Text = "Terima";
            this.buttonTerima.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPesananMasuk
            // 
            this.dataGridViewPesananMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesananMasuk.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewPesananMasuk.Name = "dataGridViewPesananMasuk";
            this.dataGridViewPesananMasuk.RowHeadersWidth = 51;
            this.dataGridViewPesananMasuk.RowTemplate.Height = 24;
            this.dataGridViewPesananMasuk.Size = new System.Drawing.Size(769, 273);
            this.dataGridViewPesananMasuk.TabIndex = 31;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(89, 52);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(141, 24);
            this.comboBoxStatus.TabIndex = 30;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(6, 44);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 32);
            this.labelUsername.TabIndex = 29;
            this.labelUsername.Text = "Status :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(289, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(213, 38);
            this.lblGASLIVERY.TabIndex = 28;
            this.lblGASLIVERY.Text = "Pesanan Masuk";
            // 
            // buttonTolak
            // 
            this.buttonTolak.BackColor = System.Drawing.Color.Transparent;
            this.buttonTolak.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTolak.Location = new System.Drawing.Point(132, 361);
            this.buttonTolak.Name = "buttonTolak";
            this.buttonTolak.Size = new System.Drawing.Size(114, 35);
            this.buttonTolak.TabIndex = 35;
            this.buttonTolak.Text = "Tolak";
            this.buttonTolak.UseVisualStyleBackColor = false;
            // 
            // buttonLihatDetail
            // 
            this.buttonLihatDetail.BackColor = System.Drawing.Color.Transparent;
            this.buttonLihatDetail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatDetail.Location = new System.Drawing.Point(252, 361);
            this.buttonLihatDetail.Name = "buttonLihatDetail";
            this.buttonLihatDetail.Size = new System.Drawing.Size(163, 35);
            this.buttonLihatDetail.TabIndex = 36;
            this.buttonLihatDetail.Text = "Lihat Detail";
            this.buttonLihatDetail.UseVisualStyleBackColor = false;
            // 
            // FormPesananMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 409);
            this.Controls.Add(this.buttonLihatDetail);
            this.Controls.Add(this.buttonTolak);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonTerima);
            this.Controls.Add(this.dataGridViewPesananMasuk);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormPesananMasuk";
            this.Text = "FormPesananMasuk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesananMasuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button buttonTerima;
        private System.Windows.Forms.DataGridView dataGridViewPesananMasuk;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Button buttonTolak;
        private System.Windows.Forms.Button buttonLihatDetail;
    }
}