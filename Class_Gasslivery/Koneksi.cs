using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_Gasslivery
{
    public class Koneksi
    {
        private MySqlConnection myKon;

        public MySqlConnection MyKon { get => myKon; set => myKon = value; }

        public Koneksi()
        {
            MyKon = new MySqlConnection();
            myKon.ConnectionString = "Server=192.168.137.1;Database=db_gasslivery;Uid=amri;Pwd=123";
            Connect();
        }

        public Koneksi(string server, string database, string uid, string pwd)
        {
            MyKon = new MySqlConnection();
            myKon.ConnectionString = $"Server={server};Database={database};Uid={uid};Pwd={pwd}";
            Connect();
        }

        public void Connect()
        {
            if (MyKon.State == System.Data.ConnectionState.Open)
            {
                MyKon.Close();
            }
            MyKon.Open();
        }
        public static void JalankanPerintahDML(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.MyKon);
            cmd.ExecuteNonQuery();
        }

        public static MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.MyKon);
            MySqlDataReader drHasil = cmd.ExecuteReader();
            return drHasil;
        }
    }
}
