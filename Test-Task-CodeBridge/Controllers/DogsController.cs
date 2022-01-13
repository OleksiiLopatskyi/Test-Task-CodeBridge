using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services;

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
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
