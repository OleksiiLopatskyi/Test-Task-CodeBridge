using System;
using System.Collections.Generic;
using System.Linq;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService.AbstractFactory
{
    public class TailHeightSort : AbstractSort
    {
        public TailHeightSort(string orderBy) : base(orderBy) { }

        public override IQueryable<Dog> Sort(IQueryable<Dog> unsortedList)
        {
            return OrderBy == string.Empty ? unsortedList.OrderBy(i => i.Tail_Height) : unsortedList.OrderByDescending(i => i.Tail_Height);
        }
    }
}
