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
    public class LoadFeaturedBrandViewComponent : ViewComponent
    {
        private readonly IBrandManager _iBrandManager;
        private readonly IBrandPhotoManager _iBrandPhotoManager;

        public LoadFeaturedBrandViewComponent(IBrandManager iBrandManager, IBrandPhotoManager iBrandPhotoManager)
        {
            _iBrandManager = iBrandManager;
            _iBrandPhotoManager = iBrandPhotoManager;
        }

        public IViewComponentResult Invoke()
        {
            ICollection<Brand> getFeaturedbrands = _iBrandManager.GetAll()
                .Where(b => b.Featured == true && b.Status == true).ToList();

            ICollection<BrandPhoto> getFeaturedBrandPhoto = _iBrandPhotoManager.GetAll()
                .Where(bp => bp.Featured == true && bp.Status == true).ToList();

            if (getFeaturedbrands == null)
                getFeaturedbrands = new List<Brand>();

            if (getFeaturedBrandPhoto == null)
                getFeaturedBrandPhoto = new List<BrandPhoto>();

            ViewBag.BrandPhotos = getFeaturedBrandPhoto;            
            return View(getFeaturedbrands);
        }
    }
}
