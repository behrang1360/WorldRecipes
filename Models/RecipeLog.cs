using System;

namespace WorldRecipes.Models
{
    public class RecipeLog
    {
        public int RecipeLogId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public User UpdateByUser { get; set; }

        public DateTime UdpateTime { get; set; }
    }
}