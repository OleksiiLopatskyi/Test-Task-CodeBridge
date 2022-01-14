using System;
using System.Collections.Generic;
using System.Linq;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService.AbstractFactory
{
    public class ColorSort : AbstractSort
    {
        public ColorSort(string orderBy) : base(orderBy) { }
   
        public override IQueryable<Dog> Sort(IQueryable<Dog> unsortedList)
        {
            return OrderBy == string.Empty ? unsortedList.OrderBy(i => i.Color) : unsortedList.OrderByDescending(i => i.Color);
        }
    }
}
