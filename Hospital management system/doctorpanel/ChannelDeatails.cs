using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Hospital_management_system.database;
using Hospital_management_system.Login_panel;

namespace Hospital_management_system.doctorpanel
{
    public partial class ChannelDeatails : Form
    {
        connectionstring constr = new connectionstring();
        public ChannelDeatails()
        {
            InitializeComponent();
        }

        private void ChannelDeatails_Load(object sender, EventArgs e)
        {
            getchannleList();
        }

        public void getchannleList()
        {
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "select * from channeling where channelDate = @date and doctorID= @docid ";

                using (SqlCommand com = new SqlCommand(query,con))
                {

                    com.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                    com.Parameters.AddWithValue("@docid",loggingform.uniquid);


                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView1.DataSource = dt;
                    }
                    
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
