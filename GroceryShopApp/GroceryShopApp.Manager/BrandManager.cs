using GroceryShopApp.Manager.Base;
using GroceryShopApp.Manager.Contracts;
using GroceryShopApp.Models.Models;
using GroceryShopApp.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryShopApp.Manager
{
    public class BrandManager : BaseManager<Brand>, IBrandManager
    {
        private readonly IBrandRepository _iBrandRepository;

        public BrandManager(IBrandRepository iBrandRepository) : base(iBrandRepository)
        {
            _iBrandRepository = iBrandRepository;
        }
    }
}
