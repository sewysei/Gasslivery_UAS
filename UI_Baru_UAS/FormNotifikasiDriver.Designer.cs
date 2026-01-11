namespace UI_Baru_UAS
{
    partial class FormNotifikasiDriver
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
            this.dataGridViewNotifikasiDriver = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifikasiDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(300, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(221, 38);
            this.lblGASLIVERY.TabIndex = 16;
            this.lblGASLIVERY.Text = "Notifikasi Driver";
            // 
            // dataGridViewNotifikasiDriver
            // 
            this.dataGridViewNotifikasiDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotifikasiDriver.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewNotifikasiDriver.Name = "dataGridViewNotifikasiDriver";
            this.dataGridViewNotifikasiDriver.RowHeadersWidth = 51;
            this.dataGridViewNotifikasiDriver.RowTemplate.Height = 24;
            this.dataGridViewNotifikasiDriver.Size = new System.Drawing.Size(776, 300);
            this.dataGridViewNotifikasiDriver.TabIndex = 17;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(12, 356);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(132, 35);
            this.buttonRefresh.TabIndex = 27;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(656, 356);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(132, 35);
            this.buttonTutup.TabIndex = 31;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            // 
            // FormNotifikasiDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewNotifikasiDriver);
            this.Controls.Add(this.lblGASLIVERY);
            this.Name = "FormNotifikasiDriver";
            this.Text = "FormNotifikasiDriver";
            this.Load += new System.EventHandler(this.FormNotifikasiDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifikasiDriver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.DataGridView dataGridViewNotifikasiDriver;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonTutup;
    }
}