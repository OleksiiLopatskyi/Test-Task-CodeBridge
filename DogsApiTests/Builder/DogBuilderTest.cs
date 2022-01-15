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
        public void Build_Test()
        {
            //Arrange
            string name = "Jessy";
            string color = "black & white";
            double height = 23.456;
            double weight = 20.0123;

            //Act
            Dog dog = new DogBuilder().
                SetName(name).
                SetColor(color).
                SetTailHeight(height).
                SetWeight(weight).
                Build();

            //Assert
            Assert.Equal(name, dog.Name);
            Assert.Equal(color, dog.Color);
            Assert.Equal(height, dog.Tail_Height);
            Assert.Equal(weight, dog.Weight);

        }
    }
}
