using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services.SortService.AbstractFactory;

namespace Test_Task_CodeBridge.Services.Builder
{
    public interface ISortBuilder
    {
        ISortBuilder DefineOrder(string orderBy);
        ISortBuilder DefineProperty(string sortProperty);
        AbstractSort Build();
    }
}
