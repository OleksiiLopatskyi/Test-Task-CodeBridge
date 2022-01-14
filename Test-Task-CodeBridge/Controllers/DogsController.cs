using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services.Repositories;
using Test_Task_CodeBridge.Services.SortService;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Controllers
{
    [ApiController]
    [Route("api")]
    public class DogsController : Controller
    {
        private readonly IDogRepository _dogRepository;
        private readonly IDataSortService _sortService;
        public DogsController(IServiceProvider serviceProvider,
                              IDataSortService sortService)
        {
            _dogRepository = new DogRepository(serviceProvider);
            _sortService = sortService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Index([FromQuery]SortViewModel sortModel,[FromQuery]IndexViewModel indexModel)
        {
            if (ModelState.IsValid)
            {
                var dogs = _dogRepository.GetAllDogs();
                var paginatedDogs = await _sortService.GetPaginatedDogs(sortModel, indexModel, dogs);
                return Ok(paginatedDogs);
            }
            else
            {
                return BadRequest("Invalid request");
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateDog(DogViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _dogRepository.CreateDogAsync(model);
                if (result)
                {
                    return Ok("Success");
                }
                return BadRequest(new InvalidOperationException().Message);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

    }
}
