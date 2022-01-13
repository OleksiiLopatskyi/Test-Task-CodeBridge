using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Controllers
{
    [ApiController]
    [Route("api")]
    public class DogsController : Controller
    {
        private readonly IDogRepository _dogRepository;
        public DogsController(IServiceProvider serviceProvider)
        {
            _dogRepository =new DogRepository(serviceProvider);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _dogRepository.GetAllDogsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateDog(DogViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _dogRepository.CreateDogAsync(model);
                if (result)
                {
                    return BadRequest("Failed");
                }
                return Ok("Success");
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
    }
}
