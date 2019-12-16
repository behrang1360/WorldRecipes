using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldRecipes.Models;
using WorldRecipes.Services;

namespace WorldRecipes.Controllers
{

    [Route("api/[controller]")]
    public class FoodRecipeController : ControllerBase
    {

        private readonly ILogger<FoodRecipeController> _logger;
        private readonly IFoodRecipeServices _foodRecipeServices;

        public FoodRecipeController(ILogger<FoodRecipeController> logger, IFoodRecipeServices
          foodRecipeServices)
        {
            _logger = logger;
            _foodRecipeServices = foodRecipeServices;
        }

        [HttpPost("addRecipe")]
        public async Task<IActionResult> AddRecipe(Recipe recipe)
        {
            await _foodRecipeServices.AddRecipe(recipe);
            return StatusCode(200);
        }


        [HttpPost("addFood")]
        public async Task<IActionResult> AddFood(Food food)
        {
            await _foodRecipeServices.AddFood(food);
            return StatusCode(200);
        }

        [HttpPost("updateRecipe")]
        public async Task<IActionResult> UpdateRecipe(Recipe recipe, User user)
        {
            await _foodRecipeServices.UpdateRecipe(recipe, user);
            return StatusCode(200);
        }


        [HttpPost("UpdateFood")]
        public async Task<IActionResult> updateFood(Food food, User user)
        {
            await _foodRecipeServices.UpdateFood(food, user);
            return StatusCode(200);
        }


    }
}
