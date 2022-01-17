using System;
using System.Collections.Generic;
using System.Linq;
using Test_Task_CodeBridge.Services.Pagination;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.ViewModels;
using Test_Task_CodeBridge.Services.SortService.AbstractFactory;
using Test_Task_CodeBridge.Services.Builder;
using Microsoft.EntityFrameworkCore;

namespace Test_Task_CodeBridge.Services.SortService
{
    public class DataSortService : IDataSortService
    {
        public async Task<PaginatedList<Dog>> GetPaginatedDogs(SortViewModel sortModel, IndexViewModel indexModel,IQueryable<Dog>dogList)
        {
            var sortedDogs = await GetSortedDogs(sortModel, dogList).ToListAsync();
            var paginatedDogs = await PaginatedList<Dog>.CreateAsync(sortedDogs.AsQueryable(), indexModel.PageNumber, indexModel.PageSize);
            return paginatedDogs;
        }

        public IQueryable<Dog> GetSortedDogs(SortViewModel model,IQueryable<Dog>dogList)
        {
            AbstractSort selectedSortType = new SortBuilder()
                                                .DefineOrder(model.OrderBy)
                                                .DefineProperty(model.Property)
                                                .Build();
            
            return selectedSortType.Sort(dogList);
        }
    }
}
