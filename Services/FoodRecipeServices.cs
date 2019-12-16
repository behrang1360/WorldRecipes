using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldRecipes.Data;
using WorldRecipes.Models;

namespace WorldRecipes.Services
{
    public class FoodRecipeServices : IFoodRecipeServices
    {
        private readonly DataContext _dataContext;

        public FoodRecipeServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddFood(Food food)
        {
            _dataContext.Foods.Add(food);

            await _dataContext.SaveChangesAsync();
        }

        public async Task AddRecipe(Recipe recipe)
        {
            _dataContext.Recipes.Add(recipe);

            await _dataContext.SaveChangesAsync();
        }

        public Task<IEnumerable<Food>> GetFoodByCountery(int id)
        {
            throw new System.NotImplementedException();
        }

        public Food GetFoodById(int id, User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Recipe>> GetFoodRecipes(Food food)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateFood(Food food, User user)
        {
            //Add Log
            if (user.UserAccess.CanEdit)
            {
                var oldValue = _dataContext.Foods.Where(f => f.FoodId == food.FoodId).FirstOrDefault();
                _dataContext.FoodLogs.Add(new FoodLog()
                {
                    UpdateByUser = user,
                    Food = oldValue,
                    UdpateTime = DateTime.Now
                });
                oldValue.Description = food.Description;
                oldValue.Name = food.Name;
                await _dataContext.SaveChangesAsync();
            }
        }

       

        public async Task UpdateRecipe(Recipe recipe, User user)
        {
            if (user.UserAccess.CanEdit)
            {
                var oldValue = _dataContext.Recipes.Where(r => r.RecipeId == recipe.RecipeId).FirstOrDefault();
                _dataContext.recipeLogs.Add(new RecipeLog()
                {
                    UpdateByUser = user,
                    UdpateTime = DateTime.Now,
                    Description = oldValue.Description,
                    Ingredient = oldValue.Ingredient,
                    Quantity = oldValue.Quantity
                });
                oldValue.Description = recipe.Description;
                oldValue.Food = recipe.Food;
                oldValue.Ingredient = recipe.Ingredient;
                oldValue.Quantity = recipe.Quantity;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}