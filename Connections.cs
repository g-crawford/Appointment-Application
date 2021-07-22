using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace C969___Scheduler_App
{
    public static class Connections
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public static MySqlCommand mySqlCommand = new MySqlCommand();
    }
}
