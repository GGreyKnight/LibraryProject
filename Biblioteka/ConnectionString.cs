using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public static class ConnectionString
    {
        public static string connectionString;// = @"Data Source=.\libraryDB.db;Version=3";

        public static void setConnectionString(string myConnectionString)
        {
            connectionString = myConnectionString;
        }
    }
}
