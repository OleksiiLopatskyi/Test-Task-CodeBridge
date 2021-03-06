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
        [Route("Dogs")]
        public async Task<IActionResult> Index([FromQuery]SortViewModel sortModel,[FromQuery]IndexViewModel indexModel)
        {
            if (ModelState.IsValid)
            {
                var dogs = await _dogRepository.GetAllDogs();
                var paginatedDogs = await _sortService.GetPaginatedDogs(sortModel, indexModel, dogs.AsQueryable());

                return indexModel.PageNumber > paginatedDogs.TotalPages?BadRequest("Invalid page number"):Ok(paginatedDogs);
            }
            return BadRequest("Check input fields");
        }
        [HttpPost]
        [Route("dog")]
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

        [HttpGet]
        [Route("ping")]
        public IActionResult ShowPing()
        {
            return Ok("Dogs house service. Version 1.0.1");
        }

    }
}
