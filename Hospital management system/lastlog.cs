using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Hospital_management_system.database;

namespace Hospital_management_system
{
    class lastlog
    {

        connectionstring constr = new connectionstring();

        public DateTime log { set; get; }

        public DateTime getlastlog(string email)
        {
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "select lastdate from lastlogin where email='"+email+"'";

                using(SqlCommand com = new SqlCommand(query, con))
                {
                    using(SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            log = reader.GetDateTime(0);
                        }

                        if(reader.HasRows == false)
                        {
                            log = DateTime.Now;
                        }
                       
                        

                    }
                }



            }

            return log;
        }


        public void insertlastlog(DateTime dt,string mail)
        {
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "insert into lastlogin  values('"+dt+"','"+mail+"')";

                using (SqlCommand com = new SqlCommand(query, con))
                {
                    SqlDataAdapter dA = new SqlDataAdapter();

                    dA.InsertCommand = com;
                    dA.InsertCommand.ExecuteNonQuery();
                }
            }


        }
    }
}
