using System;

namespace WorldRecipes.Models
{
    public class FoodLog
    {
        public int FoodLogId { get; set; }

        public Food Food { get; set; }

        public User UpdateByUser { get; set; }

        public DateTime UdpateTime { get; set; }
        
    }
}