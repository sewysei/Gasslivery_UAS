namespace UI_Baru_UAS
{
    partial class FormVoucher
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
            this.dataGridViewVoucher = new System.Windows.Forms.DataGridView();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVoucher
            // 
            this.dataGridViewVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucher.Location = new System.Drawing.Point(16, 75);
            this.dataGridViewVoucher.Name = "dataGridViewVoucher";
            this.dataGridViewVoucher.RowHeadersWidth = 51;
            this.dataGridViewVoucher.RowTemplate.Height = 24;
            this.dataGridViewVoucher.Size = new System.Drawing.Size(769, 273);
            this.dataGridViewVoucher.TabIndex = 19;
            this.dataGridViewVoucher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVoucher_CellContentClick);
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(249, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(302, 38);
            this.lblGASLIVERY.TabIndex = 20;
            this.lblGASLIVERY.Text = "Voucher yang Tersedia";
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(670, 367);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 28;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // FormVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewVoucher);
            this.Name = "FormVoucher";
            this.Text = "FormVoucher";
            this.Load += new System.EventHandler(this.FormVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVoucher;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Button buttonTutup;
    }
}