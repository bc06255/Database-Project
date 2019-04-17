using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    
    class DatabaseConnection
    {
        public static String connectionString = "Data Source=airportdbinstance1.cmog5krjfemw.us-east-2.rds.amazonaws.com,1433; Initial Catalog=Airport; User ID=master; Password=masterpassword;";

        public String getConnection()
        {
            return connectionString;
        }
    }

    
}
