using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GroceryShopApp.Models.Models
{
    public class BrandPhoto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Select brand please.")]
        public int BrandId { get; set; }

        [StringLength(500, MinimumLength = 2)]
        [DataType(DataType.ImageUrl)]
        public string PhotoPath { get; set; }
        public bool Status { get; set; }
        public bool Featured { get; set; }

        public Brand Brand { get; set; }
    }
}
