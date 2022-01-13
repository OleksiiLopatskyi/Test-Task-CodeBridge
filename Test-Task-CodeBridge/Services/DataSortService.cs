using System;
using System.Collections.Generic;
using System.Linq;
using Test_Task_CodeBridge.Services.Pagination;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Services
{
    public class DataSortService : IDataSortService
    {
        public async Task<PaginatedList<Dog>> GetPaginatedDogs(SortViewModel sortModel, IndexViewModel indexModel,IQueryable<Dog>dogList)
        {
            var sortedDogs = GetSortedDogs(sortModel, dogList);
            var paginatedDogs = await PaginatedList<Dog>.CreateAsync(sortedDogs, indexModel.Page, indexModel.PageSize);
            return paginatedDogs;
        }

        public IQueryable<Dog> GetSortedDogs(SortViewModel model,IQueryable<Dog>dogList)
        {
            IEnumerable<Dog> dogs = new List<Dog>();
            if (string.IsNullOrEmpty(model.Attribute))
                return dogList;

            if (string.IsNullOrEmpty(model.Order))
            {
                switch (model.Attribute)
                {
                    case "name":
                        dogs = dogList.OrderBy(i => i.Name);
                        break;
                    case "color":
                        dogs = dogList.OrderBy(i => i.Color);
                        break;
                    case "tail_height":
                        dogs = dogList.OrderBy(i => i.Tail_Length);
                        break;
                    case "tail_weight":
                        dogs = dogList.OrderBy(i => i.Weight);
                        break;
                }
            }
            else if (model.Order == "desc" || model.Order == "Desc")
            {
                switch (model.Attribute)
                {
                    case "name":
                        dogs = dogList.OrderByDescending(i => i.Name);
                        break;
                    case "color":
                        dogs = dogList.OrderByDescending(i => i.Color);
                        break;
                    case "tail_height":
                        dogs = dogList.OrderByDescending(i => i.Tail_Length);
                        break;
                    case "tail_weight":
                        dogs = dogList.OrderByDescending(i => i.Weight);
                        break;
                }
            }
            return dogs.AsQueryable();

        }
    }
}
