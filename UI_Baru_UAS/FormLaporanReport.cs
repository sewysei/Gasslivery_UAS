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
    public partial class FormLaporanReport : Form
    {
        public FormUtama frmUtama;
        public FormLaporanReport(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporanReport_Load(object sender, EventArgs e)
        {
            if (dataGridViewLaporanReport.Columns.Contains("btnCheck"))
            {
                dataGridViewLaporanReport.Columns.Remove("btnCheck");
            }
            string mulai = dateTimePickerDari.Value.Date.ToString("yyyy-MM-dd 00:00:00");
            string akhir = dateTimePickerSampai.Value.Date.ToString("yyyy-MM-dd 23:59:59");
            List<Report> listHasil = Report.BacaData(mulai, akhir);
            dataGridViewLaporanReport.DataSource = listHasil;
            dataGridViewLaporanReport.Columns["Id"].Visible = false;

            if (!dataGridViewLaporanReport.Columns.Contains("btnCheck"))
            {
                DataGridViewButtonColumn check = new DataGridViewButtonColumn();
                check.Text = "Check";
                check.HeaderText = "Check";
                check.UseColumnTextForButtonValue = true;
                check.Name = "btnCheck";
                dataGridViewLaporanReport.Columns.Add(check);
            }

            labelJumlahLaporan.Text = listHasil.Count.ToString();
        }

        private void dataGridViewLaporanReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewLaporanReport.Columns["btnCheck"].Index)
            {
                //Ambil isi datagrid pada baris yang diklik user
                Report selectedReport = (Report)dataGridViewLaporanReport.CurrentRow.DataBoundItem;
                FormCheckReport frmcheck = new FormCheckReport(frmUtama);
                frmcheck.checkReport = selectedReport;
                frmcheck.Owner = this;
                frmcheck.ShowDialog();
                FormLaporanReport_Load(this, e);
            }
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            FormLaporanReport_Load(this, e);
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            FormLaporanReport_Load(this, e);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
