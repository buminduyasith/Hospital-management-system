using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Hospital_management_system.database;
using Hospital_management_system.Login_panel;

namespace Hospital_management_system
{
    public partial class channeldoctorRes : UserControl
    {
        connectionstring constr = new connectionstring();
        private string gender;
        
        public channeldoctorRes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Channlingoutput cout = new Channlingoutput();
            cout.ShowDialog();*/

            
            search();

        }

        private void channeldoctorRes_Load(object sender, EventArgs e)

        {
           
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }


        public void search()
        {

            using(SqlConnection con = constr.getconnection())
            {
                string query = "";
                con.Open();
                query = " SELECT doctor.fname,doctor.lname,doctoravailable.docid,doctoravailable.specialization,doctoravailable.dateis,"+
                               "doctoravailable.date_as_string,doctoravailable.time" +
                                " FROM doctor" +
                                " INNER JOIN doctoravailable ON doctoravailable.docid = doctor.docid";


                if (string.IsNullOrEmpty(txtname.Text))
                {
                    query = query + " where doctoravailable.specialization = '" + cmbspec.Text + "' and doctoravailable.dateis='" + dateTimePicker1.Value + "'";
                }

                else if (!string.IsNullOrEmpty(txtname.Text))
                {
                    query = query + " where fname = '" + txtname.Text + "' and doctoravailable.dateis='" + dateTimePicker1.Value + "'";

                }

                else
                {
                    query = query + " where fname = '" + txtname.Text + "' and doctoravailable.dateis='" + dateTimePicker1.Value + "' and fname = '" + txtname.Text + "' ";

                }

                using (SqlCommand com = new SqlCommand(query, con))
                {
                   
                    using(SqlDataReader reader = com.ExecuteReader())
                    {

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView1.DataSource = dt;
                    }
                   
                }

            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtdocname.Text = row.Cells["fname"].Value.ToString();
                txtdocid.Text = row.Cells["docid"].Value.ToString();
                txtspec.Text = row.Cells["specialization"].Value.ToString();
                dtchanneldate.Value =Convert.ToDateTime( row.Cells["date_as_string"].Value);
                dtchanneltime.Text = row.Cells["time"].Value.ToString();
                getchannelnumber();
            }
        }


        private void savedb()
        {
            
           
            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "insert into channeling values(@honorifics,@fname,@lname,@gender,@age,@nic,@phone,@mail,@city," +
                    "@docname,@docid,@spec,@cdate,@ctime,@cnum,@recepid,@recepname)";

                txtchannelnum.Text = "5";
                using (SqlCommand com = new SqlCommand(query, con))
                {

                    com.Parameters.AddWithValue("@honorifics", cmbhonor.Text);
                    com.Parameters.AddWithValue("@fname",txtfname.Text);
                    com.Parameters.AddWithValue("@lname ",txtlname.Text);
                    com.Parameters.AddWithValue("@gender",gender);
                    com.Parameters.AddWithValue("@age", txtage.Text);
                    com.Parameters.AddWithValue("@nic ",txtnid.Text);
                    com.Parameters.AddWithValue("@phone",txtphonenum.Text);
                    com.Parameters.AddWithValue("@mail",txtmail.Text);
                    com.Parameters.AddWithValue("@city",txtcity.Text);
                    com.Parameters.AddWithValue("@docname",txtdocname.Text);
                    com.Parameters.AddWithValue("@docid ",txtdocid.Text);
                    com.Parameters.AddWithValue("@spec ",cmbspec.Text);
                    com.Parameters.AddWithValue("@cdate",dtchanneldate.Value);
                    com.Parameters.AddWithValue("@ctime", Convert.ToDateTime(dtchanneltime.Text)); 
                    com.Parameters.AddWithValue("@cnum ",txtchannelnum.Text);
                    com.Parameters.AddWithValue("@recepid", loggingform.uniquid);
                    com.Parameters.AddWithValue("@recepname", loggingform.name);

                    SqlDataAdapter adapter = new SqlDataAdapter();

                    adapter.InsertCommand = com;
                    adapter.InsertCommand.ExecuteNonQuery();

                    //    com.Parameters.AddWithValue("@recepid",); 
                  

                }
            }
        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            savedb();
        }

        private void getchannelnumber()
        {

            using (SqlConnection con = constr.getconnection())
            {
                con.Open();

                string query = "select count(*) from channeling where doctorID =@did and channelDate = @date";


                using (SqlCommand com = new SqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@did", txtdocid.Text);

                    com.Parameters.AddWithValue("@date",dtchanneldate.Value);

                    using(SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtchannelnum.Text = (reader.GetInt32(0) + 1).ToString();
                        }
                    }
                }

            }

        }
        


       
    }


}
