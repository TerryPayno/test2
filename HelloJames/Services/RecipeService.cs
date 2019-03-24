using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloJames.Interfaces;
using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Recipe;

namespace HelloJames.Services
{
    public class RecipeService : IRecipeService
    {
        private IRecipeRepo _RecipeRepo;

        public RecipeService(IRecipeRepo recipeRepo)
        {
            _RecipeRepo = recipeRepo;
        }

        public void AddNew(AddRecipeObj newRecipe)
        {
            _RecipeRepo.AddNew(newRecipe);
        }

        public void DeleteStock(DeleteRecipe DeleteRecipe)
        {
            _RecipeRepo.DeleteStock(DeleteRecipe);
        }

        public IEnumerable<RecipeObj> GetAll()
        {
            return _RecipeRepo.GetAll();
        }

        public void UpdateStock(UpdateRecipe UpdateRecipe)
        {
            _RecipeRepo.UpdateStock(UpdateRecipe);
        }
    }
}