using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Voucher
    {
        private string id;
        private string name;
        private string conditions;
        private string value;

        public Voucher()
        {
            this.Id = "";
            this.Name = "";
            this.Conditions = "";
            this.Value = "";
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Conditions { get => conditions; set => conditions = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
