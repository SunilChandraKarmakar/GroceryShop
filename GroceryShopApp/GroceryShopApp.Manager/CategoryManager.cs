using GroceryShopApp.Manager.Base;
using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using GroceryShopApp.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Manager
{
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        private readonly ICategoryRepository _iCategoryRepository;
        public CategoryManager(ICategoryRepository iCategoryRepository) : base(iCategoryRepository)
        {
            _iCategoryRepository = iCategoryRepository;
        }
    }
}
