using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class User
    {
        private string id;
        private string username;
        private string password;
        private string role;

        public User()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
            this.Role = "";
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
