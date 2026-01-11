namespace UI_Baru_UAS
{
    partial class FormRiwayatRide
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
            this.dataGridViewRiwayatRide = new System.Windows.Forms.DataGridView();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDari = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerSampai = new System.Windows.Forms.DateTimePicker();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonLihatDetail = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatRide)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRiwayatRide
            // 
            this.dataGridViewRiwayatRide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatRide.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewRiwayatRide.Name = "dataGridViewRiwayatRide";
            this.dataGridViewRiwayatRide.RowHeadersWidth = 51;
            this.dataGridViewRiwayatRide.RowTemplate.Height = 24;
            this.dataGridViewRiwayatRide.Size = new System.Drawing.Size(868, 241);
            this.dataGridViewRiwayatRide.TabIndex = 23;
            this.dataGridViewRiwayatRide.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRiwayatRide_CellContentClick);
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(360, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(180, 38);
            this.lblGASLIVERY.TabIndex = 24;
            this.lblGASLIVERY.Text = "Riwayat Ride";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Periode :";
            // 
            // dateTimePickerDari
            // 
            this.dateTimePickerDari.Location = new System.Drawing.Point(104, 53);
            this.dateTimePickerDari.Name = "dateTimePickerDari";
            this.dateTimePickerDari.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDari.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(310, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerSampai
            // 
            this.dateTimePickerSampai.Location = new System.Drawing.Point(337, 53);
            this.dateTimePickerSampai.Name = "dateTimePickerSampai";
            this.dateTimePickerSampai.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSampai.TabIndex = 28;
            // 
            // buttonRating
            // 
            this.buttonRating.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRating.Location = new System.Drawing.Point(746, 94);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(119, 43);
            this.buttonRating.TabIndex = 32;
            this.buttonRating.Text = "Rating";
            this.buttonRating.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(746, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 43);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(765, 328);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 63;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // buttonLihatDetail
            // 
            this.buttonLihatDetail.BackColor = System.Drawing.Color.Transparent;
            this.buttonLihatDetail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatDetail.Location = new System.Drawing.Point(12, 328);
            this.buttonLihatDetail.Name = "buttonLihatDetail";
            this.buttonLihatDetail.Size = new System.Drawing.Size(163, 35);
            this.buttonLihatDetail.TabIndex = 61;
            this.buttonLihatDetail.Text = "Lihat Detail";
            this.buttonLihatDetail.UseVisualStyleBackColor = false;
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(746, 192);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(119, 43);
            this.buttonReport.TabIndex = 64;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // FormRiwayatRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 368);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonLihatDetail);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.dateTimePickerSampai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewRiwayatRide);
            this.Name = "FormRiwayatRide";
            this.Text = "FormRiwayatRide";
            this.Load += new System.EventHandler(this.FormRiwayatRide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatRide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRiwayatRide;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSampai;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button buttonLihatDetail;
        private System.Windows.Forms.Button buttonReport;
    }
}