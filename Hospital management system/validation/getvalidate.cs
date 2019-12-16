using FluentValidation.Results;
using Hospital_management_system.modelclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.validation
{
    public class getvalidate
    {
        public ValidationResult getresult(string value)
        {
            patientmodel patient = new patientmodel();


            patient.firstname = value;

            patientregistrationvalidator validator = new patientregistrationvalidator();

            ValidationResult result = validator.Validate(patient);

            return result;
        }

    }
}
