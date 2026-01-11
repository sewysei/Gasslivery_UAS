namespace UI_Baru_UAS
{
    partial class FormRiwayatPenjualan
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
            this.labelTotalPenjualanPeriodeIni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerSampai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDari = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.dataGridViewRiwayatPenjualan = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalPenjualanPeriodeIni
            // 
            this.labelTotalPenjualanPeriodeIni.AutoSize = true;
            this.labelTotalPenjualanPeriodeIni.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPenjualanPeriodeIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalPenjualanPeriodeIni.Location = new System.Drawing.Point(258, 327);
            this.labelTotalPenjualanPeriodeIni.Name = "labelTotalPenjualanPeriodeIni";
            this.labelTotalPenjualanPeriodeIni.Size = new System.Drawing.Size(46, 22);
            this.labelTotalPenjualanPeriodeIni.TabIndex = 55;
            this.labelTotalPenjualanPeriodeIni.Text = "Rp0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(0, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Total Penjualan Periode Ini :";
            // 
            // dateTimePickerSampai
            // 
            this.dateTimePickerSampai.Location = new System.Drawing.Point(337, 55);
            this.dateTimePickerSampai.Name = "dateTimePickerSampai";
            this.dateTimePickerSampai.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSampai.TabIndex = 50;
            this.dateTimePickerSampai.ValueChanged += new System.EventHandler(this.dateTimePickerSampai_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(310, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "-";
            // 
            // dateTimePickerDari
            // 
            this.dateTimePickerDari.Location = new System.Drawing.Point(104, 55);
            this.dateTimePickerDari.Name = "dateTimePickerDari";
            this.dateTimePickerDari.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDari.TabIndex = 48;
            this.dateTimePickerDari.ValueChanged += new System.EventHandler(this.dateTimePickerDari_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Periode :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(330, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(246, 38);
            this.lblGASLIVERY.TabIndex = 46;
            this.lblGASLIVERY.Text = "Riwayat Penjualan";
            // 
            // dataGridViewRiwayatPenjualan
            // 
            this.dataGridViewRiwayatPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatPenjualan.Location = new System.Drawing.Point(6, 83);
            this.dataGridViewRiwayatPenjualan.Name = "dataGridViewRiwayatPenjualan";
            this.dataGridViewRiwayatPenjualan.RowHeadersWidth = 51;
            this.dataGridViewRiwayatPenjualan.RowTemplate.Height = 24;
            this.dataGridViewRiwayatPenjualan.Size = new System.Drawing.Size(868, 241);
            this.dataGridViewRiwayatPenjualan.TabIndex = 45;
            this.dataGridViewRiwayatPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRiwayatPenjualan_CellContentClick);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(6, 362);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(163, 35);
            this.buttonPrint.TabIndex = 57;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(759, 330);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 58;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // FormRiwayatPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 406);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelTotalPenjualanPeriodeIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerSampai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewRiwayatPenjualan);
            this.Name = "FormRiwayatPenjualan";
            this.Text = "FormRiwayatPenjualan";
            this.Load += new System.EventHandler(this.FormRiwayatPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPenjualanPeriodeIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerSampai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.DataGridView dataGridViewRiwayatPenjualan;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonTutup;
    }
}