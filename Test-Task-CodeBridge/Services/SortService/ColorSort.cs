using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService
{
    public class ColorSort : ISortable
    {
        private string orderBy;
        public ColorSort(string orderBy)
        {
            if (orderBy == null) orderBy = string.Empty;
            this.orderBy = orderBy;
        }
        public string OrderBy => orderBy;

        public IQueryable<Dog> Sort(IQueryable<Dog> unsortedList)
        {
            return orderBy == string.Empty ? unsortedList.OrderBy(i => i.Color) : unsortedList.OrderByDescending(i => i.Color);
        }
    }
}
