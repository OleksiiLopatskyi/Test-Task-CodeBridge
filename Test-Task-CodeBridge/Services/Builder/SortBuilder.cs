using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services.SortService.AbstractFactory;

namespace Test_Task_CodeBridge.Services.Builder
{
    public class SortBuilder : ISortBuilder
    {
        AbstractSort sort;
        private string orderBy;
        public SortBuilder()=>new NameSort(string.Empty);
        public AbstractSort Build() => sort;

        public ISortBuilder DefineOrder(string orderBy)
        {
            this.orderBy = orderBy == null ? string.Empty : "desc";
            return this;
        }

        public ISortBuilder DefineProperty(string sortProperty)
        {
            sort = sortProperty == null ? new NameSort(orderBy) : null;

            switch (sortProperty)
            {
                case "name":
                    sort = new NameSort(orderBy);
                    break;
                case "color":
                    sort = new ColorSort(orderBy);
                    break;
                case "tail_height":
                    sort = new TailHeightSort(orderBy);
                    break;
                case "weight":
                    sort = new TailHeightSort(orderBy);
                    break;
            }
            return this;
        }
    }
}
