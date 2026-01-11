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
            this.dataGridViewPesananMasuk = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
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
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
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
            this.dataGridViewPesananMasuk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesananMasuk_CellContentClick);
            this.dataGridViewPesananMasuk.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPesananMasuk_CellFormatting);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "pending",
            "processing",
            "delivered",
            "cancelled"});
            this.comboBoxStatus.Location = new System.Drawing.Point(91, 46);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(141, 24);
            this.comboBoxStatus.TabIndex = 30;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(6, 44);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(79, 22);
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
            // FormPesananMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 409);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.dataGridViewPesananMasuk);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormPesananMasuk";
            this.Text = "FormPesananMasuk";
            this.Load += new System.EventHandler(this.FormPesananMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesananMasuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.DataGridView dataGridViewPesananMasuk;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGASLIVERY;
    }
}