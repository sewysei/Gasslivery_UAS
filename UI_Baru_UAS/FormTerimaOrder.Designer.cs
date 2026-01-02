namespace UI_Baru_UAS
{
    partial class FormTerimaOrder
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
            this.comboBoxJenisOrder = new System.Windows.Forms.ComboBox();
            this.dataGridViewDaftarOrder = new System.Windows.Forms.DataGridView();
            this.buttonTerimaOrder = new System.Windows.Forms.Button();
            this.buttonLihatDetail = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(200, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(359, 38);
            this.lblGASLIVERY.TabIndex = 15;
            this.lblGASLIVERY.Text = "Daftar Order Yang Tersedia";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Kozuka Gothic Pr6N M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(13, 47);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(125, 32);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Jenis Order : ";
            // 
            // comboBoxJenisOrder
            // 
            this.comboBoxJenisOrder.FormattingEnabled = true;
            this.comboBoxJenisOrder.Location = new System.Drawing.Point(144, 55);
            this.comboBoxJenisOrder.Name = "comboBoxJenisOrder";
            this.comboBoxJenisOrder.Size = new System.Drawing.Size(141, 24);
            this.comboBoxJenisOrder.TabIndex = 17;
            // 
            // dataGridViewDaftarOrder
            // 
            this.dataGridViewDaftarOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarOrder.Location = new System.Drawing.Point(19, 85);
            this.dataGridViewDaftarOrder.Name = "dataGridViewDaftarOrder";
            this.dataGridViewDaftarOrder.RowHeadersWidth = 51;
            this.dataGridViewDaftarOrder.RowTemplate.Height = 24;
            this.dataGridViewDaftarOrder.Size = new System.Drawing.Size(769, 273);
            this.dataGridViewDaftarOrder.TabIndex = 18;
            // 
            // buttonTerimaOrder
            // 
            this.buttonTerimaOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonTerimaOrder.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerimaOrder.Location = new System.Drawing.Point(19, 364);
            this.buttonTerimaOrder.Name = "buttonTerimaOrder";
            this.buttonTerimaOrder.Size = new System.Drawing.Size(186, 35);
            this.buttonTerimaOrder.TabIndex = 21;
            this.buttonTerimaOrder.Text = "Terima Order";
            this.buttonTerimaOrder.UseVisualStyleBackColor = false;
            // 
            // buttonLihatDetail
            // 
            this.buttonLihatDetail.BackColor = System.Drawing.Color.Transparent;
            this.buttonLihatDetail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatDetail.Location = new System.Drawing.Point(211, 364);
            this.buttonLihatDetail.Name = "buttonLihatDetail";
            this.buttonLihatDetail.Size = new System.Drawing.Size(167, 35);
            this.buttonLihatDetail.TabIndex = 22;
            this.buttonLihatDetail.Text = "Lihat Detail";
            this.buttonLihatDetail.UseVisualStyleBackColor = false;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(673, 365);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 27;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // FormTerimaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonLihatDetail);
            this.Controls.Add(this.buttonTerimaOrder);
            this.Controls.Add(this.dataGridViewDaftarOrder);
            this.Controls.Add(this.comboBoxJenisOrder);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormTerimaOrder";
            this.Text = "FormTerimaOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ComboBox comboBoxJenisOrder;
        private System.Windows.Forms.DataGridView dataGridViewDaftarOrder;
        private System.Windows.Forms.Button buttonTerimaOrder;
        private System.Windows.Forms.Button buttonLihatDetail;
        private System.Windows.Forms.Button buttonTutup;
    }
}