using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.ViewModels.Validation;

namespace Test_Task_CodeBridge.ViewModels
{
    public class SortViewModel
    {
        [SortType]
        public string Property { get; set; }
        [OrderType]
        public string OrderBy { get; set; }
    }
}
