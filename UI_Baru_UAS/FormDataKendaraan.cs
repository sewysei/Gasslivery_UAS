using Class_Gasslivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormDataKendaraan : Form
    {
        FormUtama frm;
        public FormDataKendaraan()
        {
            InitializeComponent();
        }

        private void dataGridViewDataKendaraan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDataKendaraan.Columns["btnUbah"].Index)
            {
                Vehicle selectedVehicle = (Vehicle)dataGridViewDataKendaraan.CurrentRow.DataBoundItem;
                FormUbahKendaraan frmUbah = new FormUbahKendaraan();
                frmUbah.driver = frm.driverLogin;
                frmUbah.Owner = this;
                frmUbah.ShowDialog();
                FormDataKendaraan_Load(this, e);
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDataKendaraan_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.MdiParent;
            dataGridViewDataKendaraan.DataSource = Vehicle.BacaData("", "driver", frm.driverLogin.Id);

            if (!dataGridViewDataKendaraan.Columns.Contains("btnUbah"))
            {
                DataGridViewButtonColumn nonaktif = new DataGridViewButtonColumn();
                nonaktif.Text = "Ubah";
                nonaktif.HeaderText = "Ubah";
                nonaktif.UseColumnTextForButtonValue = true;
                nonaktif.Name = "btnUbah";
                dataGridViewDataKendaraan.Columns.Add(nonaktif);
            }
        }
    }
}
