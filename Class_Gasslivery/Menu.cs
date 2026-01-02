using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
