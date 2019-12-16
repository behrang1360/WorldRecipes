using System.Collections.Generic;
using System.Threading.Tasks;
using WorldRecipes.Models;

namespace WorldRecipes.Services
{
    public interface IFoodRecipeServices
    {
        Task AddFood(Food food);
        Task UpdateFood(Food food,User user);
        Food GetFoodById(int id, User user);
        Task<IEnumerable<Food>> GetFoodByCountery(int id);
        Task<IEnumerable<Recipe>> GetFoodRecipes(Food food);
        Task AddRecipe(Recipe recipe);
        Task UpdateRecipe(Recipe recipe,User user);
    }
}