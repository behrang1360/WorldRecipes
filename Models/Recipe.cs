using System.Collections.Generic;

namespace WorldRecipes.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public ICollection<RecipeLog> RecipeLog { get; set; }
    }
}