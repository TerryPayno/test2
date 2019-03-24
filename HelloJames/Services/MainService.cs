using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloJames.Interfaces;
using SharedObject3.SharedObjects.Recipe;
using System.Data.Entity;

using SharedObject3.SharedObjects.Stock;

namespace HelloJames.Services
{
    public class MainService : IMainService
    {
        private IRecipeService _RecipeService;
        private IStockService _StockService;

        public MainService(IRecipeService recipeService, IStockService stockService)
        {
            _RecipeService = recipeService;
            _StockService = stockService;
        }
        public IEnumerable<RecipeObj> GetAllInfo()
        {
            List<RecipeObj> RecipeList = _RecipeService.GetAll().ToList(); ;
            List<Stockobj> StockList = _StockService.GetAll().ToList();

            //Do Processing here to find If I have the stock to make the recipe!

            //So I can do this liniarly - 

            foreach (var r in RecipeList)
            {
                var query2 = StockList.Where(a => a.IngredientList
                                       .Select(b => r.RecipeID)
                                       .Select(a => StockList.Select(d => d.StockID))
                                       .Contains(d => d.StockID));
            }
           


            List<RecipeObj> Results = new List<RecipeObj>();
            return Results;
        }
    }
}