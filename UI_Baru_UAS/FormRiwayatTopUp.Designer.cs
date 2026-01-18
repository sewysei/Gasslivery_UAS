namespace UI_Baru_UAS
{
    partial class FormRiwayatTopUp
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
            this.dateTimePickerSampai = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDari = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.dataGridViewRiwayatTopUp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalTopUpPeriodeIni = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLihatDetail = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatTopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerSampai
            // 
            this.dateTimePickerSampai.Location = new System.Drawing.Point(331, 53);
            this.dateTimePickerSampai.Name = "dateTimePickerSampai";
            this.dateTimePickerSampai.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSampai.TabIndex = 39;
            this.dateTimePickerSampai.ValueChanged += new System.EventHandler(this.dateTimePickerSampai_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(304, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "-";
            // 
            // dateTimePickerDari
            // 
            this.dateTimePickerDari.Location = new System.Drawing.Point(98, 53);
            this.dateTimePickerDari.Name = "dateTimePickerDari";
            this.dateTimePickerDari.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDari.TabIndex = 37;
            this.dateTimePickerDari.ValueChanged += new System.EventHandler(this.dateTimePickerDari_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Periode :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(354, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(215, 38);
            this.lblGASLIVERY.TabIndex = 35;
            this.lblGASLIVERY.Text = "Riwayat Top Up";
            // 
            // dataGridViewRiwayatTopUp
            // 
            this.dataGridViewRiwayatTopUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatTopUp.Location = new System.Drawing.Point(6, 81);
            this.dataGridViewRiwayatTopUp.Name = "dataGridViewRiwayatTopUp";
            this.dataGridViewRiwayatTopUp.RowHeadersWidth = 51;
            this.dataGridViewRiwayatTopUp.RowTemplate.Height = 24;
            this.dataGridViewRiwayatTopUp.Size = new System.Drawing.Size(868, 241);
            this.dataGridViewRiwayatTopUp.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total Top Up Periode ini :";
            // 
            // labelTotalTopUpPeriodeIni
            // 
            this.labelTotalTopUpPeriodeIni.AutoSize = true;
            this.labelTotalTopUpPeriodeIni.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTopUpPeriodeIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalTopUpPeriodeIni.Location = new System.Drawing.Point(252, 325);
            this.labelTotalTopUpPeriodeIni.Name = "labelTotalTopUpPeriodeIni";
            this.labelTotalTopUpPeriodeIni.Size = new System.Drawing.Size(46, 22);
            this.labelTotalTopUpPeriodeIni.TabIndex = 44;
            this.labelTotalTopUpPeriodeIni.Text = "Rp0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 59;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonLihatDetail
            // 
            this.buttonLihatDetail.BackColor = System.Drawing.Color.Transparent;
            this.buttonLihatDetail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatDetail.Location = new System.Drawing.Point(9, 360);
            this.buttonLihatDetail.Name = "buttonLihatDetail";
            this.buttonLihatDetail.Size = new System.Drawing.Size(163, 35);
            this.buttonLihatDetail.TabIndex = 58;
            this.buttonLihatDetail.Text = "Lihat Detail";
            this.buttonLihatDetail.UseVisualStyleBackColor = false;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(759, 328);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 60;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // FormRiwayatTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 405);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLihatDetail);
            this.Controls.Add(this.labelTotalTopUpPeriodeIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerSampai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewRiwayatTopUp);
            this.Name = "FormRiwayatTopUp";
            this.Text = "FormRiwayatTopUp";
            this.Load += new System.EventHandler(this.FormRiwayatTopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatTopUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerSampai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.DataGridView dataGridViewRiwayatTopUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalTopUpPeriodeIni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLihatDetail;
        private System.Windows.Forms.Button buttonTutup;
    }
}