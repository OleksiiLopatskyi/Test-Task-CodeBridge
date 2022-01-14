using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.Models.Context;
using Test_Task_CodeBridge.Services.Builder;
using Test_Task_CodeBridge.Services.Repositories;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Services.Repositories
{
    public class DogRepository : IDogRepository
    {
        public IServiceProvider _serviceProvider { get; }

        private readonly DogsContext _context;
        public DogRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _context = (DogsContext)_serviceProvider.GetService(typeof(DogsContext));
        }

        public IQueryable<Dog> GetAllDogs() => _context.Dogs;
        public async Task<bool> CreateDogAsync(DogViewModel model)
        {
            Dog dog = new DogBuilder().
                SetName(model.Name).
                SetColor(model.Color).
                SetTailHeight(model.Tail_Height).
                SetWeight(model.Weight).
                Build();

            return await SaveDogAsync(dog); 
        }
        public async Task<bool> SaveDogAsync(Dog dog)
        {
            try
            {
                await _context.Dogs.AddAsync(dog);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }
    }
}
