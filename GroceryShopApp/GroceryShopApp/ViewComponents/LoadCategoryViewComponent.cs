using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShopApp.ViewComponents
{
    public class LoadCategoryViewComponent : ViewComponent 
    {
        private readonly ICategoryManager _iCategoryManager;

        public LoadCategoryViewComponent(ICategoryManager iCategoryManager)
        {
            _iCategoryManager = iCategoryManager;
        }

        public IViewComponentResult Invoke()
        {
            ICollection<Category> categories = _iCategoryManager.GetAll()
                .Where(c => c.Categorye == null).ToList();
            return View(categories);
        }
    }
}
