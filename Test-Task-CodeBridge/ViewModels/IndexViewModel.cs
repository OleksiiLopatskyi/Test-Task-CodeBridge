using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.ViewModels
{
    public class IndexViewModel:SortViewModel
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
