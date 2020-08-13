using GroceryShopApp.Manager.Base;
using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using GroceryShopApp.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Manager
{
    public class BrandPhotoManager : BaseManager<BrandPhoto>, IBrandPhotoManager
    {
        private readonly IBrandPhotoRepository _iBrandPhotoRepository;

        public BrandPhotoManager(IBrandPhotoRepository iBrandPhotoRepository) :
            base(iBrandPhotoRepository)
        {
            _iBrandPhotoRepository = iBrandPhotoRepository;        
        }
    }
}
