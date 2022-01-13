using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.ViewModels.Validation
{
    public class DogBody:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            double val = (double)value;
            if (val <= 0) return new ValidationResult("Tail value is a negative number or is not a number.");
            return null;
        }
    }
}
