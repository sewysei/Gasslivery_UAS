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
    public partial class FormUbahKendaraan : Form
    {
        public Driver driver;
        public FormUbahKendaraan()
        {
            InitializeComponent();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string merk = textBoxMerk.Text;
            string plate = textBoxPlat.Text;
            string beli = dateTimePickerBeli.Value.ToString("yyyy-MM-dd HH:mm:ss");
            Vehicle vehicle = new Vehicle();
            vehicle.Name = merk;
            vehicle.Plate = plate;
            vehicle.Buy_date = DateTime.Parse(beli);
            vehicle.Driver = driver;
            Vehicle.Ubah(vehicle);
            Driver.UpdateStatus("active", driver.Id);
            MessageBox.Show("Kendaraan berhasil diubah!");
            this.Close();
        }
    }
}
