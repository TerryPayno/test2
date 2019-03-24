using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SharedObject3.SharedObjects.Recipe;
using HelloJames.Services;
using HelloJames.Repository;


namespace HelloJames.Controllers
{
    [RoutePrefix("api/Recipe")]
    public class RecipeController : ApiController
    {
        // GET: api/Recipe
        [HttpGet, Route("GetAllRecipes")]
        public IEnumerable<RecipeObj> GetAllRecipes()    
        {
            RecipeService recipeService = new RecipeService(new RecipeDatabaseRepo());
            return recipeService.GetAll();
        }

        // GET: api/Recipe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recipe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Recipe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Recipe/5
        public void Delete(int id)
        {
        }
    }
}
