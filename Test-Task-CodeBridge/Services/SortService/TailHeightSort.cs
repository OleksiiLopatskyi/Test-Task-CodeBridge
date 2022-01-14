using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService
{
    public class TailHeightSort : ISortable
    {
        private string orderBy;
        public TailHeightSort(string orderBy)
        {
            if (orderBy == null) orderBy = string.Empty;
            this.orderBy = orderBy;
        }
        public string OrderBy => orderBy;

        public IQueryable<Dog> Sort(IQueryable<Dog> unsortedList)
        {
            return orderBy == string.Empty ? unsortedList.OrderBy(i => i.Tail_Length) : unsortedList.OrderByDescending(i => i.Tail_Length);
        }
    }
}
