using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;

namespace Library.Utils
{
    class Database
    {
        private static readonly Database instance = new Database();

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        private NpgsqlConnection conn;

        public static Database Instance
        {
            get
            {
                return instance;
            }
        }

        public NpgsqlConnection Conn { get => conn; set => conn = value; }

        //to prevent creation of multiple instances
        static Database() { }

        Database()
        {
            //creates a new connection
            conn = new NpgsqlConnection(connectionString);
        }
    }
}
