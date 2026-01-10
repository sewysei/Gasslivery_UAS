namespace UI_Baru_UAS
{
    partial class FormKelolaMenu
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
            this.buttonTambah = new System.Windows.Forms.Button();
            this.lblGASLIVERY = new System.Windows.Forms.Label();
            this.dataGridViewKelolaMenu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelolaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTutup
            // 
            this.buttonTutup.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(673, 357);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(115, 35);
            this.buttonTutup.TabIndex = 32;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = false;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(12, 357);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(115, 35);
            this.buttonTambah.TabIndex = 29;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // lblGASLIVERY
            // 
            this.lblGASLIVERY.AutoSize = true;
            this.lblGASLIVERY.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASLIVERY.Location = new System.Drawing.Point(310, 9);
            this.lblGASLIVERY.Name = "lblGASLIVERY";
            this.lblGASLIVERY.Size = new System.Drawing.Size(176, 38);
            this.lblGASLIVERY.TabIndex = 28;
            this.lblGASLIVERY.Text = "Kelola Menu";
            // 
            // dataGridViewKelolaMenu
            // 
            this.dataGridViewKelolaMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKelolaMenu.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewKelolaMenu.Name = "dataGridViewKelolaMenu";
            this.dataGridViewKelolaMenu.RowHeadersWidth = 51;
            this.dataGridViewKelolaMenu.RowTemplate.Height = 24;
            this.dataGridViewKelolaMenu.Size = new System.Drawing.Size(776, 301);
            this.dataGridViewKelolaMenu.TabIndex = 27;
            this.dataGridViewKelolaMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKelolaMenu_CellContentClick);
            // 
            // FormKelolaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 401);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.lblGASLIVERY);
            this.Controls.Add(this.dataGridViewKelolaMenu);
            this.Name = "FormKelolaMenu";
            this.Text = "FormKelolaMenu";
            this.Load += new System.EventHandler(this.FormKelolaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelolaMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label lblGASLIVERY;
        private System.Windows.Forms.DataGridView dataGridViewKelolaMenu;
    }
}