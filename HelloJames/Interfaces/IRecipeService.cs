using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Recipe;

namespace HelloJames.Interfaces
{
    public interface IRecipeService
    {
        void AddNew(AddRecipeObj newRecipe);
        void UpdateStock(UpdateRecipe UpdateRecipe);
        void DeleteStock(DeleteRecipe DeleteRecipe);
        IEnumerable<RecipeObj> GetAll();
    }
}
