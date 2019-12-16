using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Hospital_management_system.database;
using Hospital_management_system.Login_panel;

namespace Hospital_management_system.password_change
{
    public class pwdchange
    {
       
        public static int pwdstatus { set; get; }

        public static string constr = @"Data Source=LAPTOP-6P7A7UUL;Initial Catalog=hospital_management_system;Integrated Security=True";

        public static int checkaccountdefaultpwdchange()
        {
            using(SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                string query = "select pwdchange from userlogins where email ='" + loggingform.email + "'";

                using(SqlCommand com = new SqlCommand(query, con))
                {

                    using(SqlDataReader reader = com.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            pwdstatus = reader.GetInt32(0);
                        }
                    }

                    

                }
            }

            return pwdstatus;
        }
    }
}
