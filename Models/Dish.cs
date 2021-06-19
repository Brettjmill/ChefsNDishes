using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
  {
      public class Dish
      {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int DishId { get; set; }
 
        [Required(ErrorMessage = "is required")]
        [Display(Name = "Dish Name")]
        public string DishName { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(0, 5000, ErrorMessage = "must be between 1 and 5000 Calories")]
        public int? Calories { get; set; }

        [Required(ErrorMessage = "is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Tastiness")]
        public int? Tastiness { get; set; }

        [Display(Name = "Chef")]
        public int? ChefId { get; set; }

        public Chef DishCreator { get; set; }
 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
      }
  }