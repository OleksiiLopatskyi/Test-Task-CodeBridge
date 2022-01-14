using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.Builder
{
    public class DogBuilder : IDogBuilder
    {
        Dog dog;
        public DogBuilder() => dog = new Dog();
        public Dog Build() => dog;
        public IDogBuilder SetColor(string color)
        {
            dog.Color = color;
            return this;
        }

        public IDogBuilder SetName(string name)
        {
            dog.Name = name;
            return this;
        }

        public IDogBuilder SetTailHeight(double height)
        {
            dog.Tail_Height = height;
            return this;
        }

        public IDogBuilder SetWeight(double weight)
        {
            dog.Weight = weight;
            return this;
        }
    }
}
