using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.ViewModels.Validation
{
    public class OrderType:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string orderBy = (string)value;
                bool equal = "desc" == orderBy;
                if (equal==false) return new ValidationResult("Invalid order type. You can use: 'empty field' or 'desc'");
                else return null;
            }
            return null;
        }
    }
}
