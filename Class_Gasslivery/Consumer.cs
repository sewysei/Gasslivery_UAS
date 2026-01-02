using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Consumer
    {
        private string id;
        private string username;
        private string password;
        private DateTime date;
        private string gender; // ENUM('male', 'female')
        private string telp;
        private int balance;
        private int point;

        public Consumer()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
            this.Date = DateTime.Now;
            this.Gender = "";
            this.Telp = "";
            this.Balance = 0;
            this.Point = 0;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Telp { get => telp; set => telp = value; }
        public int Balance { get => balance; set => balance = value; }
        public int Point { get => point; set => point = value; }
    }
}
