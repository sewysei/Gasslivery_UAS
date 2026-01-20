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
        FormUtama frmUtama;

        public FormRiwayatRide(FormUtama frm)
        {
            InitializeComponent();
            frmUtama = frm;
        }

        private void FormRiwayatRide_Load(object sender, EventArgs e)
        {
            frmUtama = (FormUtama)this.MdiParent;
            dateTimePickerDari.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerSampai.Value = DateTime.Now;
            LoadData();
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
                string mulai = dateTimePickerDari.Value.Date.ToString("yyyy-MM-dd 00:00:00");
                string akhir = dateTimePickerSampai.Value.Date.AddDays(1).ToString("yyyy-MM-dd 23:59:59");

                List<Trip> listTrip = Trip.BacaDataByConsumer(frmUtama.consumerLogin.Id, mulai, akhir);
                
                if (dataGridViewRiwayatRide.Columns.Contains("btnRating"))
                {
                    dataGridViewRiwayatRide.DataSource = null;
                    dataGridViewRiwayatRide.Columns.Remove("btnRating");
                    dataGridViewRiwayatRide.Columns.Remove("btnCancel");
                    dataGridViewRiwayatRide.Columns.Remove("btnReport");
                }

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

                if (dataGridViewRiwayatRide.Columns["btnRating"] == null)
                {
                    DataGridViewButtonColumn btnRating = new DataGridViewButtonColumn();
                    btnRating.Text = "Rating";
                    btnRating.HeaderText = "Rating";
                    btnRating.UseColumnTextForButtonValue = true;
                    btnRating.Name = "btnRating";
                    dataGridViewRiwayatRide.Columns.Add(btnRating);
                }

                if (dataGridViewRiwayatRide.Columns["btnCancel"] == null)
                {
                    DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn();
                    btnCancel.Text = "Cancel";
                    btnCancel.HeaderText = "Cancel";
                    btnCancel.UseColumnTextForButtonValue = true;
                    btnCancel.Name = "btnCancel";
                    dataGridViewRiwayatRide.Columns.Add(btnCancel);
                }

                if (dataGridViewRiwayatRide.Columns["btnReport"] == null)
                {
                    DataGridViewButtonColumn btnReport = new DataGridViewButtonColumn();
                    btnReport.Text = "Report";
                    btnReport.HeaderText = "Report";
                    btnReport.UseColumnTextForButtonValue = true;
                    btnReport.Name = "btnReport";
                    dataGridViewRiwayatRide.Columns.Add(btnReport);
                }

                dataGridViewRiwayatRide.Tag = listTrip;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDari_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateTimePickerSampai_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonLihatDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewRiwayatRide.CurrentRow != null && dataGridViewRiwayatRide.Tag is List<Trip> tripList)
            {
                int index = dataGridViewRiwayatRide.CurrentRow.Index;
                if (index >= 0 && index < tripList.Count)
                {
                    Trip trip = tripList[index];
                    string detail = $"Detail Trip\n\n" +
                        $"ID Trip: {trip.Id}\n" +
                        $"Tanggal: {trip.Date:yyyy-MM-dd}\n" +
                        $"Status: {trip.Status}\n" +
                        $"Titik Jemput: {trip.Pickup_point}\n" +
                        $"Titik Tujuan: {trip.Destination_point}\n" +
                        $"Jarak: {trip.Distance:F2} KM\n" +
                        $"Waktu Jemput: {trip.Pickup_time}\n" +
                        $"Driver: {(trip.Driver != null ? trip.Driver.Full_name : "-")}\n" +
                        $"Rating: {(trip.Rating > 0 ? trip.Rating.ToString() : "Belum ada rating")}\n" +
                        $"Biaya Dasar: Rp {int.Parse(trip.Fee):N0}\n" +
                        $"Biaya Tambahan: Rp {trip.Additional_fee:N0}\n" +
                        $"Diskon: Rp {trip.Discount_value:N0}\n" +
                        $"Total Biaya: Rp {trip.Total_fee:N0}";

                    MessageBox.Show(detail, "Detail Trip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih trip terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewRiwayatRide_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridViewRiwayatRide.Tag is List<Trip> tripList)
            {
                if (e.RowIndex >= 0 && e.RowIndex < tripList.Count)
                {
                    Trip trip = tripList[e.RowIndex];
                    
                    if (e.ColumnIndex == dataGridViewRiwayatRide.Columns["btnRating"].Index)
                    {
                        if (trip.Status != "completed")
                        {
                            MessageBox.Show("Rating hanya bisa diberikan untuk trip yang sudah selesai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (trip.Rating > 0)
                        {
                            MessageBox.Show("Trip ini sudah diberi rating!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        bool hasDriver = trip.Driver != null && !string.IsNullOrEmpty(trip.Driver.Id);
                        if (!hasDriver)
                        {
                            MessageBox.Show("Trip ini belum ada driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        FormRating formRating = new FormRating(trip);
                        if (formRating.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                trip.Status = "completed";
                                Trip.UpdateStatus(trip);
                                Trip.UpdateRating(trip);
                                MessageBox.Show("Rating berhasil diberikan dan transaksi telah diverifikasi selesai!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error memberikan rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (e.ColumnIndex == dataGridViewRiwayatRide.Columns["btnCancel"].Index)
                    {
                        if (trip.Status == "completed" || trip.Status == "canceled")
                        {
                            MessageBox.Show("Trip ini tidak bisa dibatalkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        FormCancelTrip formCancel = new FormCancelTrip(trip);
                        if (formCancel.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                Cancel cancel = new Cancel();
                                cancel.Trip = trip;
                                cancel.Reason = formCancel.AlasanCancel;
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
                    else if (e.ColumnIndex == dataGridViewRiwayatRide.Columns["btnReport"].Index)
                    {
                        bool hasDriver = trip.Driver != null && !string.IsNullOrEmpty(trip.Driver.Id);
                        if (!hasDriver)
                        {
                            MessageBox.Show("Trip ini belum ada driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        FormReportTrip formReport = new FormReportTrip(trip);
                        if (formReport.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                Report report = new Report();
                                report.Trip = trip;
                                report.Messages = formReport.PesanReport;
                                Report.TambahReport(report);
                                MessageBox.Show("Report berhasil dikirim! Admin akan memeriksa laporan Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error mengirim report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
