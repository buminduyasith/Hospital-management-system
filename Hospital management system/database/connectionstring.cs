using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Hospital_management_system.database
{
    class connectionstring
    {
        string constr = @"Data Source=LAPTOP-6P7A7UUL;Initial Catalog=hospital_management_system;Integrated Security=True";


        public SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection(constr);
            return con;
        }


    }
}




       