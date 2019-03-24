using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloJames.Interfaces;
using HelloJames.Services;
using HelloJames.Repository;
using SharedObject3.SharedObjects.Recipe;


namespace HelloJames.Controllers
{
    [RoutePrefix("api/Main")]
    public class MainController : ApiController
    {
        private IMainService _MainService;

        public MainController()
        {
            _MainService = new MainService(new RecipeService(new RecipeDatabaseRepo()), new StockService(new StockDatabaseRepo()));
        }
        // GET: api/Main
        [HttpGet, Route("GetAllInfo")]
        public IEnumerable<RecipeObj> Get()
        {
            return _MainService.GetAllInfo();
        }

        // GET: api/Main/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Main
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Main/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Main/5
        public void Delete(int id)
        {
        }
    }
}
