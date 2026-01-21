namespace UI_Baru_UAS
{
    partial class FormRiwayatTarikDana
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
            this.labelTotalPenarikanPeriodeIni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerSampai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDari = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.dataGridViewRiwayatPenarikanDana = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatPenarikanDana)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(678, 337);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 95;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // labelTotalPenarikanPeriodeIni
            // 
            this.labelTotalPenarikanPeriodeIni.AutoSize = true;
            this.labelTotalPenarikanPeriodeIni.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPenarikanPeriodeIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalPenarikanPeriodeIni.Location = new System.Drawing.Point(265, 334);
            this.labelTotalPenarikanPeriodeIni.Name = "labelTotalPenarikanPeriodeIni";
            this.labelTotalPenarikanPeriodeIni.Size = new System.Drawing.Size(21, 22);
            this.labelTotalPenarikanPeriodeIni.TabIndex = 92;
            this.labelTotalPenarikanPeriodeIni.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(6, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "Total Penarikan Periode Ini :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerSampai
            // 
            this.dateTimePickerSampai.Location = new System.Drawing.Point(334, 59);
            this.dateTimePickerSampai.Name = "dateTimePickerSampai";
            this.dateTimePickerSampai.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSampai.TabIndex = 90;
            this.dateTimePickerSampai.ValueChanged += new System.EventHandler(this.dateTimePickerSampai_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(307, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "-";
            // 
            // dateTimePickerDari
            // 
            this.dateTimePickerDari.Location = new System.Drawing.Point(101, 59);
            this.dateTimePickerDari.Name = "dateTimePickerDari";
            this.dateTimePickerDari.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDari.TabIndex = 88;
            this.dateTimePickerDari.ValueChanged += new System.EventHandler(this.dateTimePickerDari_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "Periode :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(247, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(322, 38);
            this.lblGASLIVERY.TabIndex = 86;
            this.lblGASLIVERY.Text = "Riwayat Penarikan Dana";
            // 
            // dataGridViewRiwayatPenarikanDana
            // 
            this.dataGridViewRiwayatPenarikanDana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatPenarikanDana.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewRiwayatPenarikanDana.Name = "dataGridViewRiwayatPenarikanDana";
            this.dataGridViewRiwayatPenarikanDana.RowHeadersWidth = 51;
            this.dataGridViewRiwayatPenarikanDana.RowTemplate.Height = 24;
            this.dataGridViewRiwayatPenarikanDana.Size = new System.Drawing.Size(781, 244);
            this.dataGridViewRiwayatPenarikanDana.TabIndex = 85;
            // 
            // FormRiwayatTarikDana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.labelTotalPenarikanPeriodeIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerSampai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewRiwayatPenarikanDana);
            this.Name = "FormRiwayatTarikDana";
            this.Text = "FormRiwayatTarikDana";
            this.Load += new System.EventHandler(this.FormRiwayatTarikDana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatPenarikanDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Label labelTotalPenarikanPeriodeIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerSampai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.DataGridView dataGridViewRiwayatPenarikanDana;
    }
}