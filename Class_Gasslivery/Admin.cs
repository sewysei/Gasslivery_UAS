using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Admin
    {
        private string id;
        private string username;
        private string password;

        public Admin()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
