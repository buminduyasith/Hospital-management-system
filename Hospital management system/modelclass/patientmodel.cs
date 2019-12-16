using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.modelclass
{
   public class patientmodel
    {

        public string title { set; get; }
        public  string firstname { set; get; }
        public string middlename { set; get; }

        public string lastname { set; get; }

        public string nid { set; get; }

        public string gender { set; get; }

        public string relationship { set; get; }

        public DateTime dateofbirth { set; get; }

        public string mobileno { set; get; }



        public string telephone { set; get; }

        public string email { set; get; }

        public string city { set; get; }

        public string address { set; get; }

        public string bloodgroup { set; get; }

        public string medicalrec { set; get; }

        public DateTime dateofentry { set; get; }


        public string fullname()
        {
            return title + " " + firstname + " " + middlename + " " + lastname;
        }

        public int age()
        {

            int a = DateTime.Now.Year - dateofbirth.Year;

            return a;
        }

        public DateTime getdateofentry()
        {
            dateofentry = DateTime.Now;
            return dateofentry;
        }
    }
}
