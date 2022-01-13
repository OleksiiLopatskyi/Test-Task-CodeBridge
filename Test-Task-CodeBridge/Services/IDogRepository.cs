using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;

namespace Test_Task_CodeBridge.Services
{
    public interface IDogRepository
    {
        IServiceProvider _serviceProvider { get; set;}
        Task<IEnumerable<Dog>> GetAllDogs();
    }
}
