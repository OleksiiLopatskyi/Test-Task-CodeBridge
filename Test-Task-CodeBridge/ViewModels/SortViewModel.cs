using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.ViewModels.Validation;

namespace Test_Task_CodeBridge.ViewModels
{
    public class SortViewModel
    {
        [SortAttribute]
        public string Attribute { get; set; }
        [OrderBy]
        public string Order { get; set; }
    }
}
