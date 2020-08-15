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
        private readonly IBrandPhotoManager _iBrandPhotoManager;

        public LoadBrandViewComponent(IBrandManager iBrandManager, IBrandPhotoManager iBrandPhotoManager)
        {
            _iBrandManager = iBrandManager;
            _iBrandPhotoManager = iBrandPhotoManager;
        }

        public IViewComponentResult Invoke()
        {
            ICollection<Brand> brands = _iBrandManager.GetAll()
                .Where(b => b.Featured == true && b.Status == true).ToList();
            ViewBag.BrandPhotos = _iBrandPhotoManager.GetAll()
                .Where(bp => bp.Featured == true && bp.Status == true).ToList();
            
            return View(brands);
        }
    }
}
