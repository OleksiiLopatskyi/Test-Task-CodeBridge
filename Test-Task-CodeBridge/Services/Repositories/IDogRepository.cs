using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Services.Repositories
{
    public interface IDogRepository
    {
        IServiceProvider _serviceProvider { get;}
        Task<List<Dog>> GetAllDogs();
        Task<bool> CreateDogAsync(DogViewModel model);
        Task<bool> SaveDogAsync(Dog dog);
    }
}
