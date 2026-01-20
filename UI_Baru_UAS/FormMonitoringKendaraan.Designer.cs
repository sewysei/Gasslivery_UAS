namespace UI_Baru_UAS
{
    partial class FormMonitoringKendaraan
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
            this.labelTotalKendaraan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.dataGridViewMonitoringKendaraan = new System.Windows.Forms.DataGridView();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitoringKendaraan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalKendaraan
            // 
            this.labelTotalKendaraan.AutoSize = true;
            this.labelTotalKendaraan.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalKendaraan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalKendaraan.Location = new System.Drawing.Point(181, 372);
            this.labelTotalKendaraan.Name = "labelTotalKendaraan";
            this.labelTotalKendaraan.Size = new System.Drawing.Size(21, 22);
            this.labelTotalKendaraan.TabIndex = 69;
            this.labelTotalKendaraan.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Total Kendaraan :";
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(233, 52);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(167, 22);
            this.textBoxCari.TabIndex = 63;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Cari Plat Kendaraan :";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(12, 397);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(163, 35);
            this.buttonPrint.TabIndex = 61;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(666, 376);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 59;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // dataGridViewMonitoringKendaraan
            // 
            this.dataGridViewMonitoringKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonitoringKendaraan.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewMonitoringKendaraan.Name = "dataGridViewMonitoringKendaraan";
            this.dataGridViewMonitoringKendaraan.RowHeadersWidth = 51;
            this.dataGridViewMonitoringKendaraan.RowTemplate.Height = 24;
            this.dataGridViewMonitoringKendaraan.Size = new System.Drawing.Size(769, 273);
            this.dataGridViewMonitoringKendaraan.TabIndex = 58;
            this.dataGridViewMonitoringKendaraan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonitoringKendaraan_CellContentClick);
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(242, 0);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(304, 38);
            this.lblGASLIVERY.TabIndex = 55;
            this.lblGASLIVERY.Text = "Monitoring Kendaraan";
            // 
            // FormMonitoringKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 457);
            this.Controls.Add(this.labelTotalKendaraan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.dataGridViewMonitoringKendaraan);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormMonitoringKendaraan";
            this.Text = "FormMonitoringKendaraan";
            this.Load += new System.EventHandler(this.FormMonitoringKendaraan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitoringKendaraan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotalKendaraan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.DataGridView dataGridViewMonitoringKendaraan;
        private System.Windows.Forms.Label lblGASLIVERY;
    }
}