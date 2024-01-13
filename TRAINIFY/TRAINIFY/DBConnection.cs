using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINIFY
{
    internal class DBConnection
    {
        //connection string
        string connection = @"Data Source = CHAMINDU; Initial Catalog = Trainify; Integrated Security = True";

        //method to get 
        public SqlConnection GetDBConnection()
        {
            SqlConnection connObj = new SqlConnection(connection);
            connObj.Open();
            return connObj;
        }
    }
}
