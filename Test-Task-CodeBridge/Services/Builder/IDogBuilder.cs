using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services.Builder
{
    public interface IDogBuilder
    {
        IDogBuilder SetName(string name);
        IDogBuilder SetColor(string color);
        IDogBuilder SetTailHeight(double height);
        IDogBuilder SetWeight(double weight);
        Dog Build();
    }
}
