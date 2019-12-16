using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorldRecipes.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        [Required]
        public Ingredient Ingredient { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Food Food { get; set; }

        public ICollection<RecipeLog> RecipeLog { get; set; }
    }
}