namespace UI_Baru_UAS
{
    partial class FormDataKendaraan
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
            this.dataGridViewDataKendaraan = new System.Windows.Forms.DataGridView();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.buttonTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataKendaraan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataKendaraan
            // 
            this.dataGridViewDataKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataKendaraan.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewDataKendaraan.Name = "dataGridViewDataKendaraan";
            this.dataGridViewDataKendaraan.RowHeadersWidth = 51;
            this.dataGridViewDataKendaraan.RowTemplate.Height = 24;
            this.dataGridViewDataKendaraan.Size = new System.Drawing.Size(776, 301);
            this.dataGridViewDataKendaraan.TabIndex = 0;
            this.dataGridViewDataKendaraan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataKendaraan_CellContentClick);
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(287, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(221, 38);
            this.lblGASLIVERY.TabIndex = 9;
            this.lblGASLIVERY.Text = "Data Kendaraan";
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(673, 357);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 26;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // FormDataKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewDataKendaraan);
            this.Name = "FormDataKendaraan";
            this.Text = "FormDataKendaraan";
            this.Load += new System.EventHandler(this.FormDataKendaraan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataKendaraan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataKendaraan;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.Button buttonTutup;
    }
}