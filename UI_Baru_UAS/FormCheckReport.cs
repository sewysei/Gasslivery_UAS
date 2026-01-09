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
    public partial class FormCheckReport : Form
    {
        public Report checkReport;
        FormUtama frm;
        public FormCheckReport(FormUtama formUtama)
        {
            InitializeComponent();
            frm = formUtama;
        }

        private void FormCheckReport_Load(object sender, EventArgs e)
        {
            if(checkReport.Status == "closed")
            {
                checkBoxBersalah.Enabled = false;
                buttonSelesaiReport.Enabled = false;
                buttonGetReport.Enabled = false;
            }
            else if (checkReport.Status == "pending")
            {
                buttonGetReport.Enabled = false;
                buttonSelesaiReport.Enabled = true;
                checkBoxBersalah.Enabled = true;
            }
            else if (checkReport.Status == "open")
            {
                checkBoxBersalah.Enabled = false;
                buttonSelesaiReport.Enabled = false;
            }
            labelReportID.Text = checkReport.Id;
            labelAlasan.Text = checkReport.Messages;
            labelStatus.Text = checkReport.Status;
            labelTanggal.Text = checkReport.Date.ToString("yyyy-MM-dd");
            labelKonsumen.Text = checkReport.Trip.Consumer.Username;
            labelDriver.Text = checkReport.Trip.Driver.Full_name;
            labelAdmin.Text = checkReport.Admin.Username;
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelesaiReport_Click(object sender, EventArgs e)
        {
            if(checkBoxBersalah.Checked)
            {
                if(checkReport.Trip.Driver.Avg_rating > 1)
                {
                    checkReport.Trip.Driver.Avg_rating -= 1;
                }
                else if (checkReport.Trip.Driver.Avg_rating < 0)
                {
                    checkReport.Trip.Driver.Avg_rating = 0;
                }
            }
            checkReport.Status = "closed";
            Report.UbahStatus(checkReport);
            FormCheckReport_Load(this,e);
        }

        private void buttonGetReport_Click(object sender, EventArgs e)
        {
            checkReport.Status = "pending";
            checkReport.Admin = frm.adminLogin;
            Report.UbahStatus(checkReport);
            FormCheckReport_Load(this, e);
        }
    }
}
