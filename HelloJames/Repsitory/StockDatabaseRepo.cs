using System.Collections.Generic;
using HelloJames.Interfaces;
using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Stock;

namespace HelloJames.Repository
{
    public class StockDatabaseRepo : IStockRepo
    {
        public void AddNew(AddStockObj newStock)
        {
            //Use Dapper here to add to Database
        }

        public void DeleteStock(DeleteStockObj DeleteStock)
        {
            //Dapper
        }

        public IEnumerable<Stockobj> GetAll()
        {
            //Dapper
            IEnumerable<Stockobj> Result = null;
            return Result;
        }

        public void UpdateStock(UpdateStockObj UpdateStock)
        {
            //Dapper
        }
    }
}