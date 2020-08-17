using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using Microsoft.AspNetCore.Mvc;
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
            ICollection<Brand> getBrands = _iBrandManager.GetAll()
                .Where(b => b.Status == true).ToList();

            if (getBrands == null)
                getBrands = new List<Brand>();

            return View(getBrands);
        }
    }
}
