using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models.Context;

namespace Test_Task_CodeBridge.ViewModels.Validation
{
    public class DogName:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string dogName = (string)value;
            var context = (DogsContext)validationContext.GetService(typeof(DogsContext));
            bool isExists = context.Dogs.Any(i => i.Name == dogName);

            if (isExists) return new ValidationResult("Dog with the same name already exists in DB.");

            return null;
        }
    }
}
