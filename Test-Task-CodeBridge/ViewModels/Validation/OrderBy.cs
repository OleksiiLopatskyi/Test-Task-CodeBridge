using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.ViewModels.Validation
{
    public class OrderBy:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string by = (string)value;
                by = by.ToLower();
                if (string.IsNullOrEmpty(by) || by == "desc")
                {
                    return null;
                }
                else
                {
                    return new ValidationResult("Invalid sorting order");
                }
            }
            else
            {
                return null;
            }
        }
    }
}
