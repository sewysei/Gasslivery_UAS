namespace UI_Baru_UAS
{
    partial class FormMonitoringDriver
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
            this.dataGridViewMonitoringDriver = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInactive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalDriver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitoringDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(666, 358);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 42;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // dataGridViewMonitoringDriver
            // 
            this.dataGridViewMonitoringDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonitoringDriver.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewMonitoringDriver.Name = "dataGridViewMonitoringDriver";
            this.dataGridViewMonitoringDriver.RowHeadersWidth = 51;
            this.dataGridViewMonitoringDriver.RowTemplate.Height = 24;
            this.dataGridViewMonitoringDriver.Size = new System.Drawing.Size(769, 273);
            this.dataGridViewMonitoringDriver.TabIndex = 40;
            this.dataGridViewMonitoringDriver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonitoringDriver_CellContentClick);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.comboBoxStatus.Location = new System.Drawing.Point(89, 40);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(136, 24);
            this.comboBoxStatus.TabIndex = 39;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUsername.Location = new System.Drawing.Point(6, 40);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(79, 22);
            this.labelUsername.TabIndex = 38;
            this.labelUsername.Text = "Status :";
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(275, 4);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(244, 38);
            this.lblGASLIVERY.TabIndex = 37;
            this.lblGASLIVERY.Text = "Monitoring Driver";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(12, 380);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(163, 35);
            this.buttonPrint.TabIndex = 45;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Total Driver :";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.BackColor = System.Drawing.Color.Transparent;
            this.labelActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelActive.Location = new System.Drawing.Point(241, 354);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(21, 22);
            this.labelActive.TabIndex = 49;
            this.labelActive.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(173, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Aktif :";
            // 
            // labelInactive
            // 
            this.labelInactive.AutoSize = true;
            this.labelInactive.BackColor = System.Drawing.Color.Transparent;
            this.labelInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelInactive.Location = new System.Drawing.Point(402, 354);
            this.labelInactive.Name = "labelInactive";
            this.labelInactive.Size = new System.Drawing.Size(21, 22);
            this.labelInactive.TabIndex = 51;
            this.labelInactive.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(278, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tidak Aktif :";
            // 
            // labelTotalDriver
            // 
            this.labelTotalDriver.AutoSize = true;
            this.labelTotalDriver.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotalDriver.Location = new System.Drawing.Point(142, 354);
            this.labelTotalDriver.Name = "labelTotalDriver";
            this.labelTotalDriver.Size = new System.Drawing.Size(21, 22);
            this.labelTotalDriver.TabIndex = 53;
            this.labelTotalDriver.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(268, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "|";
            // 
            // FormMonitoringDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalDriver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelInactive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.dataGridViewMonitoringDriver);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormMonitoringDriver";
            this.Text = "FormMonitoringDriver";
            this.Load += new System.EventHandler(this.FormMonitoringDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitoringDriver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.DataGridView dataGridViewMonitoringDriver;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInactive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalDriver;
        private System.Windows.Forms.Label label3;
    }
}