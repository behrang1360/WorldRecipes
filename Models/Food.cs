using System;
namespace WorldRecipes.Models
{
    public class Food
    {
        public int FoodId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime InsertDate{ get; set; }
        
        public User InsertUser { get; set; }                      
    }
}