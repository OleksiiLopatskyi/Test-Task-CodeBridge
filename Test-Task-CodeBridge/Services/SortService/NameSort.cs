using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService
{
    public class NameSort : ISortable
    {
        private string orderBy;
        public NameSort(string orderBy)
        {
            if (orderBy == null) orderBy = string.Empty;
            this.orderBy = orderBy;
        }
        public string OrderBy => orderBy;

        public IQueryable<Dog> Sort(IQueryable<Dog> unsortedList)
        {
            return orderBy == string.Empty ? unsortedList.OrderBy(i => i.Name) : unsortedList.OrderByDescending(i => i.Name);
        }
    }
}
