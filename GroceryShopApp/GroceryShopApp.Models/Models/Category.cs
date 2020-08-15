using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GroceryShopApp.Models.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Provide category name")]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Sub Category")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Provide description of category")]
        [StringLength(1000, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public bool Status { get; set; }

        public Category Categorye { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<CategoryPhoto> CategoryPhotos { get; set; }
    }
}
