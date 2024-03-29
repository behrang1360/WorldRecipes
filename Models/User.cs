using System;
using System.Collections.Generic;

namespace WorldRecipes.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }     
        public Country Country { get; set; }
        public ICollection<Recipe> Recipe { get; set; }
        public UserAccess UserAccess { get; set; }
    }
}
