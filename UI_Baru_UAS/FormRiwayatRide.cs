using Class_Gasslivery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI_Baru_UAS
{
    public partial class FormRiwayatRide : Form
    {
        public FormUtama frmUtama;
        private Trip selectedTrip;

        public FormRiwayatRide(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void FormRiwayatRide_Load(object sender, EventArgs e)
        {
            dateTimePickerDari.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerSampai.Value = DateTime.Now;
            LoadData();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            dateTimePickerDari.ValueChanged += (s, ev) => LoadData();
            dateTimePickerSampai.ValueChanged += (s, ev) => LoadData();
            dataGridViewRiwayatRide.SelectionChanged += DataGridViewRiwayatRide_SelectionChanged;
            buttonRating.Click += ButtonRating_Click;
            buttonCancel.Click += ButtonCancel_Click;
            buttonReport.Click += ButtonReport_Click;
            buttonLihatDetail.Click += ButtonLihatDetail_Click;
            buttonTutup.Click += ButtonTutup_Click;
        }

        private void LoadData()
        {
            if (frmUtama?.consumerLogin == null)
            {
                MessageBox.Show("Anda harus login sebagai consumer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                string mulai = dateTimePickerDari.Value.Date.ToString("yyyy-MM-dd");
                string akhir = dateTimePickerSampai.Value.Date.AddDays(1).ToString("yyyy-MM-dd");

                List<Trip> listTrip = Trip.BacaDataByConsumer(frmUtama.consumerLogin.Id, mulai, akhir);
                
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Tanggal", typeof(DateTime));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Titik Jemput", typeof(string));
                dt.Columns.Add("Titik Tujuan", typeof(string));
                dt.Columns.Add("Jarak (KM)", typeof(double));
                dt.Columns.Add("Waktu Jemput", typeof(string));
                dt.Columns.Add("Driver", typeof(string));
                dt.Columns.Add("Rating", typeof(int));
                dt.Columns.Add("Total Biaya", typeof(int));

                foreach (Trip trip in listTrip)
                {
                    dt.Rows.Add(
                        trip.Id,
                        trip.Date,
                        trip.Status,
                        trip.Pickup_point,
                        trip.Destination_point,
                        trip.Distance,
                        trip.Pickup_time,
                        trip.Driver != null && !string.IsNullOrEmpty(trip.Driver.Full_name) ? trip.Driver.Full_name : "-",
                        trip.Rating,
                        trip.Total_fee
                    );
                }

                dataGridViewRiwayatRide.DataSource = dt;
                dataGridViewRiwayatRide.Columns["ID"].Visible = false;
                dataGridViewRiwayatRide.Columns["Total Biaya"].DefaultCellStyle.Format = "N0";
                dataGridViewRiwayatRide.Columns["Jarak (KM)"].DefaultCellStyle.Format = "0.00";
                
                dataGridViewRiwayatRide.Tag = listTrip;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DataGridViewRiwayatRide_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRiwayatRide.CurrentRow != null && dataGridViewRiwayatRide.Tag is List<Trip> tripList)
            {
                int index = dataGridViewRiwayatRide.CurrentRow.Index;
                if (index >= 0 && index < tripList.Count)
                {
                    selectedTrip = tripList[index];
                    UpdateButtonStates();
                }
            }
        }

        private void UpdateButtonStates()
        {
            if (selectedTrip == null)
            {
                buttonRating.Enabled = false;
                buttonCancel.Enabled = false;
                buttonReport.Enabled = false;
                return;
            }

            bool isCompleted = selectedTrip.Status == "completed";
            bool isCanceled = selectedTrip.Status == "canceled";
            bool isOngoing = selectedTrip.Status == "ongoing";
            bool hasRating = selectedTrip.Rating > 0;
            bool hasDriver = selectedTrip.Driver != null && !string.IsNullOrEmpty(selectedTrip.Driver.Id);

            buttonRating.Enabled = (isCompleted || isOngoing) && !hasRating && hasDriver;

            buttonCancel.Enabled = !isCompleted && !isCanceled;

            buttonReport.Enabled = hasDriver;
        }

        private void ButtonRating_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null)
            {
                MessageBox.Show("Pilih trip terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedTrip.Status != "completed" && selectedTrip.Status != "ongoing")
            {
                MessageBox.Show("Rating hanya bisa diberikan untuk trip yang sedang berlangsung atau sudah selesai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedTrip.Rating > 0)
            {
                MessageBox.Show("Trip ini sudah diberi rating!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormRating formRating = new FormRating(selectedTrip);
            if (formRating.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedTrip.Status = "completed";
                    Trip.UpdateStatus(selectedTrip);
                    Trip.UpdateRating(selectedTrip);
                    MessageBox.Show("Rating berhasil diberikan dan transaksi telah diverifikasi selesai!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memberikan rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null)
            {
                MessageBox.Show("Pilih trip terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedTrip.Status == "completed" || selectedTrip.Status == "canceled")
            {
                MessageBox.Show("Trip ini tidak bisa dibatalkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormCancelTrip formCancel = new FormCancelTrip(selectedTrip);
            if (formCancel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cancel cancel = new Cancel
                    {
                        Trip = selectedTrip,
                        Reason = formCancel.AlasanCancel
                    };
                    Cancel.TambahCancel(cancel);
                    MessageBox.Show("Trip berhasil dibatalkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error membatalkan trip: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null)
            {
                MessageBox.Show("Pilih trip terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormReportTrip formReport = new FormReportTrip(selectedTrip);
            if (formReport.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Report report = new Report
                    {
                        Trip = selectedTrip,
                        Messages = formReport.PesanReport
                    };
                    Report.TambahReport(report);
                    MessageBox.Show("Report berhasil dikirim! Admin akan memeriksa laporan Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error mengirim report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonLihatDetail_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null)
            {
                MessageBox.Show("Pilih trip terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string detail = $"Detail Trip\n\n" +
                $"ID Trip: {selectedTrip.Id}\n" +
                $"Tanggal: {selectedTrip.Date:yyyy-MM-dd}\n" +
                $"Status: {selectedTrip.Status}\n" +
                $"Titik Jemput: {selectedTrip.Pickup_point}\n" +
                $"Titik Tujuan: {selectedTrip.Destination_point}\n" +
                $"Jarak: {selectedTrip.Distance:F2} KM\n" +
                $"Waktu Jemput: {selectedTrip.Pickup_time}\n" +
                $"Driver: {(selectedTrip.Driver != null ? selectedTrip.Driver.Full_name : "-")}\n" +
                $"Rating: {(selectedTrip.Rating > 0 ? selectedTrip.Rating.ToString() : "Belum ada rating")}\n" +
                $"Biaya Dasar: Rp {int.Parse(selectedTrip.Fee):N0}\n" +
                $"Biaya Tambahan: Rp {selectedTrip.Additional_fee:N0}\n" +
                $"Diskon: Rp {selectedTrip.Discount_value:N0}\n" +
                $"Total Biaya: Rp {selectedTrip.Total_fee:N0}";

            MessageBox.Show(detail, "Detail Trip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewRiwayatRide_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
