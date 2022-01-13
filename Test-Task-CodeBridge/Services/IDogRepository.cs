using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Services
{
    public interface IDogRepository
    {
        IServiceProvider _serviceProvider { get;}
        Task<IEnumerable<Dog>> GetAllDogsAsync();
        Task<bool> CreateDogAsync(DogViewModel model);
    }
}
