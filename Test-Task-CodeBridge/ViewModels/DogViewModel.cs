using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Test_Task_CodeBridge.ViewModels.Validation;

namespace Test_Task_CodeBridge.ViewModels
{
    public class DogViewModel
    {
        [Required]
        [DogName]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(20)]
        public string Color { get; set; }

        [DogBody]
        [Required]
        public double Tail_Length { get; set; }

        [DogBody]
        [Required]
        public double Weight { get; set; }
    }
}
