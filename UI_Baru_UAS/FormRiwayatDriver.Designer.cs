namespace UI_Baru_UAS
{
    partial class FormRiwayatDriver
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
            this.dataGridViewDaftarOrder = new System.Windows.Forms.DataGridView();
            this.comboBoxJenisOrder = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(673, 386);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 32;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // dataGridViewDaftarOrder
            // 
            this.dataGridViewDaftarOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarOrder.Location = new System.Drawing.Point(19, 106);
            this.dataGridViewDaftarOrder.Name = "dataGridViewDaftarOrder";
            this.dataGridViewDaftarOrder.RowHeadersWidth = 51;
            this.dataGridViewDaftarOrder.RowTemplate.Height = 24;
            this.dataGridViewDaftarOrder.Size = new System.Drawing.Size(769, 273);
            this.dataGridViewDaftarOrder.TabIndex = 31;
            this.dataGridViewDaftarOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarOrder_CellContentClick);
            // 
            // comboBoxJenisOrder
            // 
            this.comboBoxJenisOrder.FormattingEnabled = true;
            this.comboBoxJenisOrder.Items.AddRange(new object[] {
            "Gass-ride",
            "Gass-kan"});
            this.comboBoxJenisOrder.Location = new System.Drawing.Point(143, 56);
            this.comboBoxJenisOrder.Name = "comboBoxJenisOrder";
            this.comboBoxJenisOrder.Size = new System.Drawing.Size(141, 24);
            this.comboBoxJenisOrder.TabIndex = 30;
            this.comboBoxJenisOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisOrder_SelectedIndexChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(12, 48);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(132, 22);
            this.labelUsername.TabIndex = 29;
            this.labelUsername.Text = "Jenis Order : ";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(298, 0);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(197, 38);
            this.lblGASLIVERY.TabIndex = 28;
            this.lblGASLIVERY.Text = "Riwayat Order";
            // 
            // FormRiwayatDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.dataGridViewDaftarOrder);
            this.Controls.Add(this.comboBoxJenisOrder);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormRiwayatDriver";
            this.Text = "FormRiwayatDriver";
            this.Load += new System.EventHandler(this.FormRiwayatDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.DataGridView dataGridViewDaftarOrder;
        private System.Windows.Forms.ComboBox comboBoxJenisOrder;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGASLIVERY;
    }
}