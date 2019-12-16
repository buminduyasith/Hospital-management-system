using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_management_system.database;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hospital_management_system.adminpanelthing
{
    public partial class patientdetails : UserControl
    {
        connectionstring constr = new connectionstring();
      
        public patientdetails()
        {
            InitializeComponent();
        }

        private void patientdetails_Load(object sender, EventArgs e)
        {
            
        }

        private void dgwpatientinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwpatientinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  txtsearch.Text = dgwpatientinfo.SelectedRows[1].Cells[1].Value.ToString();
           // txtlastname.Text = dgwpatientinfo.SelectedRows[2].Cells[1].Value.ToString();
           // txtid.Text = dgwpatientinfo.SelectedRows[2].Cells[2].Value.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           
            

          
           

          
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            string sqlquery = string.Empty;
          

            if (txtsearch.Text != "")
            {
                if (rbfn.Checked == true)
                {

                    sqlquery = "select * from patientreg  where Firstname like '" + txtsearch.Text + "%' ";
                    search(sqlquery);
                }

                else if (rbln.Checked == true)
                {
                    sqlquery = "select * from patientreg  where lastname like '" + txtsearch.Text + "%' ";
                    search(sqlquery);
                }

                else if (rbnid.Checked == true)
                {
                    sqlquery = "select * from patientreg  where nid like '" + txtsearch.Text + "%' ";
                    search(sqlquery);

                }

                else if (rbpid.Checked == true)
                {
                    sqlquery = "select * from patientreg  where patientid like '" + txtsearch.Text + "%' ";
                    search(sqlquery);
                }

                else if (rbphoneno.Checked == true)
                {
                    sqlquery = "select * from patientreg  where mobileno like '" + txtsearch.Text + "%' ";
                    search(sqlquery);
                }

                else
                {
                   
                    return;
                }

                search(sqlquery);
            }

            else
            {
                dgwpatientinfo.DataSource = null;
                dgwpatientinfo.Refresh();
            }





          



            /*
            string sqlquery = "select * from patientreg  where Firstname like '" + txtsearch.Text+ "%' ";

            if (txtsearch.Text != "")
            {
               

            }

            else
            {
                dgwpatientinfo.DataSource = null;
                dgwpatientinfo.Refresh();


            }*/


        }

        private void search(string sqlquery)
        {
           
            SqlConnection con = constr.getconnection();
            con.Open();
            SqlCommand com = new SqlCommand(sqlquery, con);
            DataTable dtusers = new DataTable();
            SqlDataReader reader = com.ExecuteReader();
            dtusers.Load(reader);
            dgwpatientinfo.DataSource = dtusers;
            com.Dispose();
            reader.Close();
            con.Close();
        }

       

     

      

        
    }
}
