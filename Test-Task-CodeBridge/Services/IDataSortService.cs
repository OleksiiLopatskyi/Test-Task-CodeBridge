using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.Services.Pagination;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Services
{
    public interface IDataSortService
    {
        IQueryable<Dog> GetSortedDogs(SortViewModel model,IQueryable<Dog>dogList);
        Task<PaginatedList<Dog>> GetPaginatedDogs(SortViewModel sortModel, IndexViewModel indexModel,IQueryable<Dog>Dogs);
    }
}
