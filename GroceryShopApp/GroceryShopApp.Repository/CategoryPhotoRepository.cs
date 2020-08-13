using GroceryShopApp.Models.Models;
using GroceryShopApp.Repository.Base;
using GroceryShopApp.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Repository
{
    public class CategoryPhotoRepository : BaseRepository<CategoryPhoto>, ICategoryPhotoRepository
    {
    }
}
