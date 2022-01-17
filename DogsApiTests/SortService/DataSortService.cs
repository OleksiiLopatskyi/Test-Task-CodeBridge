using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Moq;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.Services.Pagination;
using Test_Task_CodeBridge.Services.SortService.AbstractFactory;
using Xunit;
using Xunit.Extensions;
using Microsoft.EntityFrameworkCore.Query;

namespace DogsApiTests.SortService
{
    public class DataSortService
    {
       public List<Dog> dogs = new List<Dog>() {
            new Dog(){Name="a",Color="a",Tail_Height=1,Weight=1},
            new Dog(){Name="b",Color="b",Tail_Height=2,Weight=2},
            new Dog(){Name="c",Color="c",Tail_Height=3,Weight=3},
            };

        [Fact]
        public void GetSortedDogs_Test()
        {
            //Arrange
           
            //Act
            List<Dog> sortedByName = new NameSort(null).Sort(dogs.AsQueryable()).ToList();
            List<Dog> sortedByNameDesc = new NameSort("desc").Sort(dogs.AsQueryable()).ToList();

            List<Dog> sortedByColor = new ColorSort(null).Sort(dogs.AsQueryable()).ToList();
            List<Dog> sortedByColorDesc = new ColorSort("desc").Sort(dogs.AsQueryable()).ToList();

            List<Dog> sortedByHeight = new TailHeightSort(null).Sort(dogs.AsQueryable()).ToList();
            List<Dog> sortedByHeightDesc = new TailHeightSort("desc").Sort(dogs.AsQueryable()).ToList();

            List<Dog> sortedByWeight = new WeightSort(null).Sort(dogs.AsQueryable()).ToList();
            List<Dog> sortedByWeightDesc = new WeightSort("desc").Sort(dogs.AsQueryable()).ToList();
            //Assert
            Assert.Equal(dogs.ElementAt(0).Name,sortedByName[0].Name);
            Assert.Equal(dogs.ElementAt(2).Name, sortedByNameDesc[0].Name);

            Assert.Equal(dogs.ElementAt(0).Color, sortedByColor[0].Color);
            Assert.Equal(dogs.ElementAt(2).Color, sortedByColorDesc[0].Color);

            Assert.Equal(dogs.ElementAt(0).Tail_Height, sortedByHeight[0].Tail_Height);
            Assert.Equal(dogs.ElementAt(2).Tail_Height, sortedByHeightDesc[0].Tail_Height);

            Assert.Equal(dogs.ElementAt(0).Weight, sortedByWeight[0].Weight);
            Assert.Equal(dogs.ElementAt(2).Weight, sortedByWeightDesc[0].Weight);
        }
    }
}
