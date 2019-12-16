using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_management_system.database;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Hospital_management_system
{
    class registered_patient_count
    {
        connectionstring constr = new connectionstring();

        public int getcount()
        {
            int patientscount = 0;
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "select count patientid from patientreg";

                using(SqlCommand com = new SqlCommand(query, con))
                {

                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patientscount = reader.GetInt32(0);
                        }
                    }
                }
            }

            return patientscount;
        }

    }
}
