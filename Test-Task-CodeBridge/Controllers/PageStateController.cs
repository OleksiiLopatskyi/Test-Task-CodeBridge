using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services;
using Test_Task_CodeBridge.Services.Repositories;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Controllers
{
    public class PageStateController : Controller
    {
        private readonly IDogRepository _repository;
        public PageStateController(IServiceProvider serviceProvider)
        {
            _repository = new DogRepository(serviceProvider);
        }
    }
}
