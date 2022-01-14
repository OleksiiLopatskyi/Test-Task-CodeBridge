using System;
using System.Collections.Generic;
using System.Linq;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.SortService.AbstractFactory
{
    public abstract class AbstractSort
    {
        protected string OrderBy;
        public AbstractSort(string orderBy)
        {
            OrderBy = ValidateInput(orderBy);
        }
        public abstract IQueryable<Dog> Sort(IQueryable<Dog> unsortedList); 
        private string ValidateInput(string value)
        {
            value = value == null ? string.Empty : value;
            return value;
        }
    }
}
