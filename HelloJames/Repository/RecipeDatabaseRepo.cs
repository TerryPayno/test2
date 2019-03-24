using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloJames.Interfaces;
using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Recipe;

namespace HelloJames.Repository
{
    public class RecipeDatabaseRepo : IRecipeRepo
    {
        public void AddNew(AddRecipeObj newRecipe)
        {
            //Dapper
        }

        public void DeleteStock(DeleteRecipe DeleteRecipe)
        {
            //Dapper
        }

        public IEnumerable<RecipeObj> GetAll()
        {
            //Dapper
            IEnumerable<RecipeObj> TempList = null;
            
            return TempList;
        }

        public void UpdateStock(UpdateRecipe UpdateRecipe)
        {
            //Dapper
        }
    }
}