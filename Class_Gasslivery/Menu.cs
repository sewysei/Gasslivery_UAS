using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Gasslivery
{
    public class Menu
    {
        private string id;
        private string name;
        private int price;
        private int stock;
        private string halal; // ENUM('yes', 'no')
        private Tenant tenant;

        public Menu()
        {
            this.Id = "";
            this.Name = "";
            this.Price = 0;
            this.Stock = 0;
            this.Halal = "";
            this.Tenant = new Tenant();
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Halal { get => halal; set => halal = value; }
        public Tenant Tenant { get => tenant; set => tenant = value; }

        public static List<Menu> BacaData(Tenant tenant, string nilai = "")
        {
            List<Menu> listHasil = new List<Menu>();
            string perintah = "";
            if (nilai == "")
            {
                perintah = $"SELECT * FROM menus WHERE tenant_id = '{tenant.Id}' ";
            }
            else if (nilai != "")
            {
                perintah = $"SELECT * FROM menus WHERE tenant_id = '{tenant.Id}' AND " +
                    $"halal = '{nilai}' ";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Menu tampung = new Menu();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Name = hasil.GetValue(1).ToString();
                tampung.Price = int.Parse(hasil.GetValue(2).ToString());
                tampung.Stock = int.Parse(hasil.GetValue(3).ToString());
                tampung.Halal = hasil.GetValue(4).ToString();
                tampung.Tenant = tenant;
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public override string ToString()
        {
            return Name;
        }

        public static void TambahMenu(Menu menu)
        {
            string perintah = $"INSERT INTO menus (`name`, `price`, `stock`, `halal`, `tenant_id`) " +
                $"VALUES ('{menu.Name}', '{menu.Price}', '{menu.Stock}', '{menu.Halal}', '{menu.Tenant.Id}');";
            Koneksi.JalankanPerintahDML(perintah);
        }
        public static void HapusMenu(Menu menu)
        {
            string perintah = $"DELETE FROM menus WHERE(`id` = '{menu.Id}')";
            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}
