using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.Threading;
using Hospital_management_system.modelclass;
using Hospital_management_system.validation;
using Hospital_management_system.database;
using FluentValidation.Results;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hospital_management_system
{

    public partial class patientregistration : UserControl
    {
        patientmodel patient = new patientmodel();
        patientregistrationvalidator validator = new patientregistrationvalidator();
        connectionstring constr = new connectionstring();
        BindingList<string> errors = new BindingList<string>();
        string patientid = string.Empty;



        bool hide = true;
        bool hide1 = true;
        bool hide2 = true;
        public patientregistration()
        {
            InitializeComponent();
            listBox1.DataSource = errors;
            listBox1.Hide();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientregistration_Load(object sender, EventArgs e)
        {
            dateofentry.Value = DateTime.Now;
            dateofentry.Enabled = false;
            txtautoid.Enabled = false;
            idgen();
        }

       
        /*
        private void btncontactsinfodown_Click(object sender, EventArgs e)
        {

            btncontactsinfodownfun();
        }

        private void btnhealth_Click(object sender, EventArgs e)
        {
            btnhealthfun();

        }*/

        public void patientdemodownfun()
        {
           
            if (hide == false)
            {

                int iFormHeight = 25;
                Transition.run(patientdemobody, "Height", iFormHeight, new TransitionType_EaseInEaseOut(800));
                hide = true;
                // Thread.Sleep(390);
                /*
                contactsinfobody.Show();
                contactsinfoheader.Show();
                healthstatusbody.Show();
                healthstatusheader.Show();*/

            }

            else
            {
                patientdemobody.BringToFront();
                int iFormHeight = 450;
                Transition.run(patientdemobody, "Height", iFormHeight, new TransitionType_EaseInEaseOut(800));
                hide = false;
            }

        }

        public void btncontactsinfodownfun() 
        {
          

            int iDestination = 16;
            int iDestination1 = 94;
            int iFormHeight = 490;

            if (hide1)
            {
                contactsinfoheader.BringToFront();
                contactsinfobody.BringToFront();

                Transition.run(contactsinfoheader, "Top", iDestination, new TransitionType_EaseInEaseOut(1000));

                Transition.run(contactsinfobody, "Top", iDestination1, new TransitionType_EaseInEaseOut(1000));

                Transition.run(contactsinfobody, "Height", iFormHeight, new TransitionType_EaseInEaseOut(800));
                


                hide1 = false;
            }


            else

            {
                iDestination = 133;
                iDestination1 = 211;
                iFormHeight = 25;

                contactsinfoheader.BringToFront();
                contactsinfobody.BringToFront();


                Transition.run(contactsinfoheader, "Top", iDestination, new TransitionType_EaseInEaseOut(1000));

                Transition.run(contactsinfobody, "Top", iDestination1, new TransitionType_EaseInEaseOut(1000));

                Transition.run(contactsinfobody, "Height", iFormHeight, new TransitionType_EaseInEaseOut(800));

                Thread.Sleep(400);
                





               






                hide1 = true;
            }

        }

        public void btnhealthfun()  
        {
           

            int iDestination = 16;
            int iDestination1 = 94;
            int iFormHeight = 490;

            if (hide2)
            {
                healthstatusheader.BringToFront();
                healthstatusbody.BringToFront();

                Transition.run(healthstatusheader, "Top", iDestination, new TransitionType_EaseInEaseOut(1000));

                Transition.run(healthstatusbody, "Top", iDestination1, new TransitionType_EaseInEaseOut(1000));

                Transition.run(healthstatusbody, "Height", iFormHeight, new TransitionType_EaseInEaseOut(800));

               
                hide2 = false;

            }
            else
            {
                iDestination = 251;
                iDestination1 = 329;
                iFormHeight = 25;




                Transition.run(healthstatusheader, "Top", iDestination, new TransitionType_EaseInEaseOut(1000));

                Transition.run(healthstatusbody, "Top", iDestination1, new TransitionType_EaseInEaseOut(1000));

                Transition.run(healthstatusbody, "Height", iFormHeight, new TransitionType_EaseInEaseOut(800));

                //Thread.Sleep(700);
              

                hide2 = true;

            }
        }



        private void cleantxt()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnNextincontact_Click(object sender, EventArgs e)
        {

            healthstatusheader.Show();
            healthstatusbody.Show();
            btnhealthfun();

        }

        private void btnbackincontact_Click(object sender, EventArgs e)
        {

            patientdemoheader.Show();
            patientdemobody.Show();
            patientdemodownfun();
        }

        private void btnnextinmedical_Click(object sender, EventArgs e)
        {


        }

        private void btnbackinmedical_Click(object sender, EventArgs e)
        {
            patientdemoheader.Hide();
            patientdemobody.Hide();
            btncontactsinfodownfun();
            contactsinfobody.Show();
            contactsinfoheader.Show();

            //tncontactsinfodown.Enabled = false;



        }

       

      
        /// working now on thie area
        private void btnextinpatientdemo_Click(object sender, EventArgs e)
        {
            validatereal();

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txtmiddelname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfirstname_Validating(object sender, CancelEventArgs e)
        {
           

           
        }


        private void idgen()
        {

            int currentyear = DateTime.Now.Year;
            int currentdate = DateTime.Now.Day;
            int currentmonth = DateTime.Now.Month;
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            string time = h +""+m+""+s;
            patientid = currentyear + "" + currentdate + "" + currentmonth+""+time;

            txtautoid.Text = patientid;
        

         //   id = "P" + txtnid.Text.Substring(0, 2) + "" + gender + ""+1000;
          
        }

        private bool validatereal()
        {
            string gender = string.Empty;
            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if(rbfemale.Checked)
            {
                gender = "Female";
            }

            patient.firstname = txtfirstname.Text;
            patient.lastname = txtlastname.Text;
            patient.middlename = txtmiddelname.Text;
            patient.nid = txtnid.Text;
            patient.gender = gender;
            patient.relationship = cmbrelationship.Text;
            patient.dateofbirth = dtpdateofbith.Value;
            patient.mobileno =txtmobileno.Text;
            patient.telephone = txttelephone.Text;
            patient.email = txtmail.Text;
            patient.city = txtcity.Text;
            patient.address = txtaddress.Text;
            patient.bloodgroup = cmbblood.Text;
            patient.medicalrec = txtmedicalrec.Text;
            patient.dateofentry = dateofentry.Value;
            int age = patient.age();


            ValidationResult result = validator.Validate(patient);

            if (result.IsValid == false)
            {
                foreach (ValidationFailure x in result.Errors)
                {

                    errors.Add(x.ErrorMessage);
                    if (x.PropertyName == "firstname")
                    {
                        errorProvider1.SetError(txtfirstname,x.ErrorMessage);
                        
                        
                    }

                  

                    if(x.PropertyName == "lastname")
                    {
                        errorProvider1.SetError(txtlastname, x.ErrorMessage);
                    }

                   

                    if (x.PropertyName == "middlename")
                    {
                        errorProvider1.SetError(txtmiddelname, x.ErrorMessage);
                    }
                    if (x.PropertyName == "nid")
                    {
                        errorProvider1.SetError(txtnid, x.ErrorMessage);
                    }
                    if (x.PropertyName == "dateofbirth")
                    {
                        errorProvider1.SetError(dtpdateofbith, x.ErrorMessage);
                    }

                    if (x.PropertyName == "relationship")
                    {
                        errorProvider1.SetError(cmbrelationship, x.ErrorMessage);
                    }

                    if (x.PropertyName == "gender")
                    {
                        errorProvider1.SetError(gbgender, x.ErrorMessage);
                    }


                    if (x.PropertyName== "mobileno")
                    {
                        errorProvider1.SetError(txtmobileno, x.ErrorMessage);
                       
                    }

                    if (x.PropertyName == "telephone")
                    {
                        errorProvider1.SetError(txttelephone, x.ErrorMessage);
                    }

                    if (x.PropertyName == "email")
                    {
                        errorProvider1.SetError(txtmail, x.ErrorMessage);
                    }

                    if (x.PropertyName == "city")
                    {
                        errorProvider1.SetError(txtcity, x.ErrorMessage);
                    }

                    if (x.PropertyName == "address")
                    {
                        errorProvider1.SetError(txtaddress, x.ErrorMessage);

                    }

                    if (x.PropertyName == "relationship")
                    {
                        errorProvider1.SetError(cmbblood,x.ErrorMessage);
                    }

                    if (x.PropertyName == "medicalrec")
                    {
                        errorProvider1.SetError(txtmedicalrec, x.ErrorMessage);
                        
                    }





                  //  MessageBox.Show(x.ErrorMessage+ " " + x.PropertyName);



                }




            }

            else
            {
                errorProvider1.Clear();
                string query = "insert into patientreg(patientid,firstname,middelname" +
                    ",lastname,gender,nid,relationship,dob,age,mobileno,telephoneno,email,city," +
                    "address,dateofentry,bloodgroup) values('" + patientid + "'," +
                    "'" + patient.firstname + "','" + patient.middlename + "','" + patient.lastname + "'," +
                    "'" + patient.gender + "','" + patient.nid + "'," +
                    "'" + patient.relationship + "','" + patient.dateofbirth + "'," +
                    "'" + age + "','" + patient.mobileno + "','" + patient.telephone + "'," +
                    "'" + patient.email + "','" + patient.city + "','" + patient.address + "'" +
                    ",'" + patient.dateofentry + "','" + patient.bloodgroup + "')";

                savetodb(query);
                MessageBox.Show("inserted");
                return true;
            }

            return false;
        }

        private void btnhelath_Click(object sender, EventArgs e)
        {
             btnhealthfun();
        }

        private void btncontanctinformation_Click(object sender, EventArgs e)
        {
            btncontactsinfodownfun();
        }

        private void btnpatientdemodown_Click(object sender, EventArgs e)
        {
            patientdemodownfun();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            bool  res =validatereal(); 
            if (res == true)
            {

            }
            else
            {
                listBox1.Show();
            }
        }

        private void dtpdateofbith_ValueChanged(object sender, EventArgs e)
        {
            patient.dateofbirth = dtpdateofbith.Value;
            txtage.Text = patient.age().ToString();


            
        }

        private void checkoutbro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(patient.firstname);
        }

        private void savetodb(string query)
        {
            try
            {
                SqlConnection con = constr.getconnection();
                con.Open();

                SqlCommand com = new SqlCommand(query, con);

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = com;
                adapter.InsertCommand.ExecuteNonQuery();

                com.Dispose();
                adapter.Dispose();
                con.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
               
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void getchronic()
        {
           

        }
    }
}
