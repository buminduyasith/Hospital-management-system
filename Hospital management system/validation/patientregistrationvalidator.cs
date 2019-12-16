using FluentValidation;
using FluentValidation.Results;
using Hospital_management_system.modelclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.validation
{
    public class patientregistrationvalidator :AbstractValidator<patientmodel>

    {
        
        public patientregistrationvalidator()
        {
            RuleFor(p => p.firstname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("  {PropertyName} This field is required")
                .Length(3, 50).WithMessage("Enter a1 valid name")
                .Must(bevalidname).WithMessage("isn't valid name to us");


            RuleFor(p => p.middlename)
                 .Cascade(CascadeMode.StopOnFirstFailure)
                 // .NotNull().WithMessage("invalid")
                 .Length(3, 50).WithMessage("Enter a2 valid name for {PropertyName} you entered {TotalLength}").When(p => p.middlename != "")
                 .Must(bevalidname).WithMessage("isn't valid name to us {PropertyName}").When(p => p.middlename != "");



            RuleFor(p => p.lastname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("This field is required")
                .Length(3, 50).WithMessage("Enter a3 valid name for {PropertyName} you entered {TotalLength}")
                .Must(bevalidname).WithMessage("isn't valid name to us {PropertyName}");


            RuleFor(p => p.relationship)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotNull().WithMessage("invalid")
            .NotEmpty().WithMessage("This field is required");
                


            RuleFor(p => p.nid)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("This field is required")
                //.Must(haveonlynumbers).WithMessage("invalid ")
                .Must(bevalidnid).WithMessage("invalid NID number");
                

            RuleFor(p => p.dateofbirth)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("invalid")
                .LessThan(DateTime.Now);

            RuleFor(p => p.mobileno)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("this field is required")
                .Must(haveonlynumbers).WithMessage("invalid ")
                .Length(10).WithMessage("not a valid number");


            RuleFor(p => p.telephone)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("this field is required")
                .Must(haveonlynumbers).WithMessage("invalid ")
                .Length(10).WithMessage("not a valid number");

            RuleFor(p => p.email)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("this field is required")
                .EmailAddress().WithMessage("invalid email");

            RuleFor(p => p.city)
            
             .Cascade(CascadeMode.StopOnFirstFailure)
             .NotNull().WithMessage("invalid")
             .NotEmpty().WithMessage("This field is required")
             .Length(3, 30).WithMessage("invalid Name")
             .Must(bevalidname).WithMessage("Name should only contain letters");

            RuleFor(p => p.address)
                  .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("invalid")
              
                .NotEmpty().WithMessage("this field is require")
                .Length(5,200).WithMessage("Less than 200 characters");

            RuleFor(p => p.bloodgroup)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("this field is require");

            RuleFor(p => p.gender)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("invalid")
                .NotEmpty().WithMessage("this field is require");



            RuleFor(p => p.medicalrec)
              
               .Cascade(CascadeMode.StopOnFirstFailure)
                 .NotNull().WithMessage("invalid")
               .NotEmpty().WithMessage("this field is require")
               .Length(5,200).WithMessage("Less than 200 characters")
               .Must(bevalidname).WithMessage("should only can have letters");














        }

        protected bool bevalidname(string name)
        {
            return name.All(char.IsLetter);

        }

        protected bool haveonlynumbers(string value)
        {
            try
            {
                return value.All(char.IsDigit);
            }
            catch(Exception )
            {

            }

            return false;
           

        }

        protected bool bevalidnid(string nid)
        {
            if(nid.Length==10 || nid.Length == 12)
            {
                return true;
            }

            return false;
        }

        protected bool bevaliddob(DateTime date)
        {
            int currentyear = DateTime.Now.Year;
            int currentdate = DateTime.Now.Day;
            int currentmonth = DateTime.Now.Month;
            int dobyear = date.Year;
            int dobmonth = date.Month;
            int dobdate = date.Day;

            if (dobyear <= currentyear && dobyear > (currentyear - 120))
            {
                if (dobdate < currentdate && dobmonth <= currentmonth)
                {
                    return true;
                }

                return false;
            }

            return false;

        }

      
    }

}