using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using Xunit;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services.SortService.AbstractFactory;
using Test_Task_CodeBridge.Services.Builder;

namespace DogsApiTests
{
   public class SortBuilderTest
    {
        [Fact]
        public void Build_Test()
        {
            //Arrange
            string orderBy=null;
            string property = "name";
            //Act
            AbstractSort testSort = new NameSort(orderBy);
            AbstractSort sort = new SortBuilder().
                DefineOrder(orderBy).
                DefineProperty(property).
                Build();

            Assert.Equal(testSort.GetType(), sort.GetType());
        }
    }
}
