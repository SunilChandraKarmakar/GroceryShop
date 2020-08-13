using GroceryShopApp.Manager.Base;
using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using GroceryShopApp.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Manager
{
    public class CategoryPhotoManager : BaseManager<CategoryPhoto>, ICategoryPhotoManager
    {
        private readonly ICategoryPhotoRepository _iCategoryPhotoRepository;
        public CategoryPhotoManager(ICategoryPhotoRepository iCategoryPhotoRepository) :
            base(iCategoryPhotoRepository)
        {
            _iCategoryPhotoRepository = iCategoryPhotoRepository;
        }
    }
}
