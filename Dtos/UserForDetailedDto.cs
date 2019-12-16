using System;

namespace WorldRecipes.Dtos
{
    public class UserForDetailedDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
        public string Country { get; set; }
    }
}