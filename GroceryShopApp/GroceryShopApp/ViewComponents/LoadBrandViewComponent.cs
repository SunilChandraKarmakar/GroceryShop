using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShopApp.ViewComponents
{
    public class LoadBrandViewComponent : ViewComponent
    {
        private readonly IBrandManager _iBrandManager;

        public LoadBrandViewComponent(IBrandManager iBrandManager)
        {
            _iBrandManager = iBrandManager;
        }

        public IViewComponentResult Invoke()
        {
            ICollection<Brand> brands = _iBrandManager.GetAll()
                .Where(b => b.Featured == true && b.Status == true).ToList();
            return View(brands);
        }
    }
}
