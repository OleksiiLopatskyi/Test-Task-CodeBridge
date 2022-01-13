using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.Models.Context;

namespace Test_Task_CodeBridge.Services
{
    public class DogRepository : IDogRepository
    {
        public IServiceProvider _serviceProvider { get; set; }
        private readonly DogsContext _context;
        public DogRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _context = (DogsContext)_serviceProvider.GetService(typeof(DogsContext));
        }

        public async Task<IEnumerable<Dog>> GetAllDogs()
        {
            return null;
        }
    }
}
