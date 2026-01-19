namespace UI_Baru_UAS
{
    partial class FormRiwayatFood
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
            this.dataGridViewRiwayatFood = new System.Windows.Forms.DataGridView();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLihatDetail = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerSampai
            // 
            this.dateTimePickerSampai.Location = new System.Drawing.Point(337, 46);
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
            this.label2.Location = new System.Drawing.Point(310, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "-";
            // 
            // dateTimePickerDari
            // 
            this.dateTimePickerDari.Location = new System.Drawing.Point(104, 46);
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
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Periode :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(349, -4);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(188, 38);
            this.lblGASLIVERY.TabIndex = 35;
            this.lblGASLIVERY.Text = "Riwayat Food";
            // 
            // dataGridViewRiwayatFood
            // 
            this.dataGridViewRiwayatFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatFood.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewRiwayatFood.Name = "dataGridViewRiwayatFood";
            this.dataGridViewRiwayatFood.RowHeadersWidth = 51;
            this.dataGridViewRiwayatFood.RowTemplate.Height = 24;
            this.dataGridViewRiwayatFood.Size = new System.Drawing.Size(868, 308);
            this.dataGridViewRiwayatFood.TabIndex = 34;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(765, 388);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 63;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(181, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 35);
            this.button2.TabIndex = 62;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonLihatDetail
            // 
            this.buttonLihatDetail.BackColor = System.Drawing.Color.Transparent;
            this.buttonLihatDetail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLihatDetail.Location = new System.Drawing.Point(12, 388);
            this.buttonLihatDetail.Name = "buttonLihatDetail";
            this.buttonLihatDetail.Size = new System.Drawing.Size(163, 35);
            this.buttonLihatDetail.TabIndex = 61;
            this.buttonLihatDetail.Text = "Lihat Detail";
            this.buttonLihatDetail.UseVisualStyleBackColor = false;
            // 
            // buttonRating
            // 
            this.buttonRating.BackColor = System.Drawing.Color.Transparent;
            this.buttonRating.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRating.Location = new System.Drawing.Point(350, 388);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(163, 35);
            this.buttonRating.TabIndex = 64;
            this.buttonRating.Text = "Rating";
            this.buttonRating.UseVisualStyleBackColor = false;
            // 
            // FormRiwayatFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 436);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLihatDetail);
            this.Controls.Add(this.dateTimePickerSampai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewRiwayatFood);
            this.Name = "FormRiwayatFood";
            this.Text = "FormRiwayatFood";
            this.Load += new System.EventHandler(this.FormRiwayatFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerSampai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.DataGridView dataGridViewRiwayatFood;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonLihatDetail;
        private System.Windows.Forms.Button buttonRating;
    }
}