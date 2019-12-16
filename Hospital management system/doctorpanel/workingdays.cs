using Hospital_management_system.database;
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

namespace Hospital_management_system.doctorpanel
{
    public partial class workingdays : Form
    {

        connectionstring constr = new connectionstring();

        BindingList<string> dateasstring1 = new BindingList<string>();
        BindingList<DateTime> datefordb = new BindingList<DateTime>();
        string time;
        string etime;
        public workingdays()
        {
            InitializeComponent();
        }

        private void workingdays_Load(object sender, EventArgs e)
        {

        }

        // select available dates
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string dateastring = monthCalendar1.SelectionRange.Start.ToLongDateString();


            dateasstring1.Add(dateastring);

            listBox1.DataSource = dateasstring1;


        }


        //delete listbox item 
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            try
            {

                dateasstring1.RemoveAt(index);

                if (index != System.Windows.Forms.ListBox.NoMatches)
                {


                }
            }
            catch (ArgumentOutOfRangeException)
            {

                toolStripStatusLabel1.Text = "select a one";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           time = dateTimePicker1.Value.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docid = "DOC -2019- 29 -11-155416";
            string spec = "CARDIOLOGISTS";

            if (dateasstring1.Count <= 0)
            {
                MessageBox.Show("Please try agian");
                return;
            }

            try
            {
                using (SqlConnection con = constr.getconnection())
                {
                    DateTime dt;

                    string query = "insert into doctoravailable values(@docid,@spec,@dateis,@date,@time,@ETIME)";
                    con.Open();

                    using (SqlCommand com = new SqlCommand(query, con))
                    {

                        com.Parameters.AddWithValue("@docid", "");
                        com.Parameters.AddWithValue("@dateis", "");
                        com.Parameters.AddWithValue("@spec", "");
                        com.Parameters.AddWithValue("@date", "");
                        com.Parameters.AddWithValue("@time", "");
                        com.Parameters.AddWithValue("@Etime", "");


                        foreach (var item in dateasstring1)
                        {
                            com.Parameters.Clear();
                            dt = Convert.ToDateTime(item);
                            com.Parameters.AddWithValue("@docid", "").Value = docid;
                            com.Parameters.AddWithValue("@spec", "").Value = spec;
                            com.Parameters.AddWithValue("@date", "").Value = item;
                            com.Parameters.AddWithValue("@dateis", "").Value = dt;
                            com.Parameters.AddWithValue("@time", "").Value = time;
                            com.Parameters.AddWithValue("@Etime", "").Value = etime;


                            SqlDataAdapter adapter = new SqlDataAdapter();


                            adapter.InsertCommand = com;
                            adapter.InsertCommand.ExecuteNonQuery();
                        }


                    }


                }
            }
            catch (SqlException ex)
            {
                
                if (ex.Number == 2627)
                {
                    MessageBox.Show("trying to enter a enterted date");
                }

                else
                {
                    MessageBox.Show("select a time");
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            etime = dateTimePicker2.Value.ToShortTimeString();
        }
    }
}
