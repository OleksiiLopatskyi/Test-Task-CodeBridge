using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.ViewModels.Validation
{
    public class SortType:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string property = (string)value;
                if (property == "name" || property == "color" || property == "tail_height" || property == "weight")
                    return null;
                else
                    return new ValidationResult("Invalid sort type. You can use: 'name', 'color', 'tail_height', 'weight' ");
            }
            return null;
        }
    }
}
