using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GroceryShopApp.Models.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Provied brand name.")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Provied origin of brand.")]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string Origin { get; set; }

        [Required(ErrorMessage = "Provied description of brand.")]
        [StringLength(2000, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public bool Featured { get; set; }
        public bool Status { get; set; }

        public ICollection<BrandPhoto> BrandPhotos { get; set; }
    }
}
