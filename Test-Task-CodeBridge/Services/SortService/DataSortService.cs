﻿using System;
using System.Collections.Generic;
using System.Linq;
using Test_Task_CodeBridge.Services.Pagination;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Models;
using Test_Task_CodeBridge.ViewModels;

namespace Test_Task_CodeBridge.Services.SortService
{
    public class DataSortService : IDataSortService
    {
        public async Task<PaginatedList<Dog>> GetPaginatedDogs(SortViewModel sortModel, IndexViewModel indexModel,IQueryable<Dog>dogList)
        {
            var sortedDogs = GetSortedDogs(sortModel, dogList);
            var paginatedDogs = await PaginatedList<Dog>.CreateAsync(sortedDogs, indexModel.PageNumber, indexModel.PageSize);
            return paginatedDogs;
        }

        public IQueryable<Dog> GetSortedDogs(SortViewModel model,IQueryable<Dog>dogList)
        {
            ISortable selectedSortType = null;

            if (model.Property == null) selectedSortType=new NameSort(model.OrderBy);

            model.Property = model.Property.ToLower();

            switch (model.Property)
            {
                case "name":
                    selectedSortType = new NameSort(model.OrderBy);
                    break;
                case "color":
                    selectedSortType = new ColorSort(model.OrderBy);
                    break;
                case "tail_height":
                    selectedSortType = new TailHeightSort(model.OrderBy);
                    break;
                case "weight":
                    selectedSortType = new TailHeightSort(model.OrderBy);
                    break;
            }
            return selectedSortType.Sort(dogList);
        }
    }
}