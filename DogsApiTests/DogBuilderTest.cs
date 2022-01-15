using System;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using Xunit.Extensions;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.Services.Repositories;
using System.Collections.Generic;
using Moq;
using Test_Task_CodeBridge.Services.Builder;

namespace DogsApiTests
{
    public class DogBuilderTest
    {
        [Fact]
        public void SetColor_Correct_Value()
        {
            //Arrange
            string colorValue = "Red";
            Dog dog = null;
            //Act
            dog = new DogBuilder().SetColor(colorValue).Build();
            //Assert
            Assert.Equal(colorValue,dog.Color);
            
        }
    }
}
