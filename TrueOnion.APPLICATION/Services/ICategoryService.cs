﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Services
{
    public interface ICategoryService : IGenericService<CategorySaveVM, CategoryVM, Category>
    {
        public Task<CategoryListVM> GetCategories();//redundant
        public Task<CategoryVM> GetCategoriesWithChildren();
        public Task<Category> GetCategoryWithChildren(int id);
        public Task GetChildrensChildren(Category category);
    }
}
