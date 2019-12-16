using Microsoft.EntityFrameworkCore;
using WorldRecipes.Models;

namespace WorldRecipes.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<FoodLog> FoodLogs { get; set; }

        public DbSet<RecipeLog> recipeLogs { get; set; }

        public DbSet<UserAccess> userAccesses { get; set; }
    }
}