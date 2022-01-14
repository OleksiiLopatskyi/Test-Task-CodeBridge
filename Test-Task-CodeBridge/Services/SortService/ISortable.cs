using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService
{
    interface ISortable
    {
        string OrderBy { get;}
        IQueryable<Dog> Sort(IQueryable<Dog> unsortedList);
    }
}
