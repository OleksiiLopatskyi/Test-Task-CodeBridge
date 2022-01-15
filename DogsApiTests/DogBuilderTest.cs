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
        [Fact]
        public void SetName_Correct_Value()
        {
            //Arrange
            string nameValue = "Jessy";
            Dog dog = null;
            //Act
            dog = new DogBuilder().SetName(nameValue).Build();
            //Assert
            Assert.Equal(nameValue, dog.Name);
        }
        [Fact]
        public void SetTailHeight_Correct_Value()
        {
            //Arrange
            double tailValue1 = 23.567;
            double tailValue2 = 20;
            //Act
            Dog dog1 = new DogBuilder().SetTailHeight(tailValue1).Build();
            Dog dog2 = new DogBuilder().SetTailHeight(tailValue2).Build();
            //Assert
            Assert.Equal(tailValue1, dog1.Tail_Height);
            Assert.Equal(tailValue2, dog2.Tail_Height);
        }
        [Fact]
        public void SetWeight_Correct_Value()
        {
            //Arange
            double weightValue1 = 10.323;
            double weightValue2 = 10;
            //Act
            Dog dog1 = new DogBuilder().SetWeight(weightValue1).Build();
            Dog dog2 = new DogBuilder().SetWeight(weightValue2).Build();

            //Assert
            Assert.Equal(weightValue1,dog1.Weight);
            Assert.Equal(weightValue2, dog2.Weight);
        }
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
