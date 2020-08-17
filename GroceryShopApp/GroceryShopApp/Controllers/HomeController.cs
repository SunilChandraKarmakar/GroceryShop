using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GroceryShopApp.Models;
using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;

namespace GroceryShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryManager _iCategoryManager;
        private readonly ICategoryPhotoManager _iCategoryPhotoManager;

        public HomeController(ILogger<HomeController> logger, ICategoryManager iCategoryManager,
            ICategoryPhotoManager iCategoryPhotoManager)
        {
            _logger = logger;
            _iCategoryManager = iCategoryManager;
            _iCategoryPhotoManager = iCategoryPhotoManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetSubCategoryByParentCategoryId(int? id)
        {
            if (id == null)
                return NotFound();

            ICollection<Category> getSubCategory = _iCategoryManager.GetAll()
                .Where(c => c.CategoryId == id).ToList();
            ICollection<CategoryPhoto> getFeaturedCategoryPhotos = _iCategoryPhotoManager.GetAll()
                .Where(cp => cp.Featured == true && cp.Status == true).ToList();

            if (getSubCategory == null)
                getSubCategory = new List<Category>();

            if (getFeaturedCategoryPhotos == null)
                getFeaturedCategoryPhotos = new List<CategoryPhoto>();

            ViewBag.GetFeaturedCategoryPhotos = getFeaturedCategoryPhotos;
            return View(getSubCategory);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
