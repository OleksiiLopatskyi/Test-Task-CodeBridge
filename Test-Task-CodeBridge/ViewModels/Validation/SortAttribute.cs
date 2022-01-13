using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.ViewModels.Validation
{
    public class SortAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string attribute = (string)value;
                attribute = attribute.ToLower();
                switch (attribute)
                {
                    case "name":
                        return null;
                    case "color":
                        return null;
                    case "tail_height":
                        return null;
                    case "tail_weight":
                        return null;
                    default:
                        return new ValidationResult("Invalid sorting attribute");
                }
            }
            return null;
         
        }
    }
}
