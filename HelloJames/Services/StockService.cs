using System.Collections.Generic;
using HelloJames.Interfaces;
using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Stock;

namespace HelloJames.Services
{
    public class StockService : IStockService
    {
        //Is this unit testable?????
        //Yes as we are using constructor injection
        private IStockRepo _Stockrepo;

        public StockService(IStockRepo StockRepo)
        {
            _Stockrepo = StockRepo;
        }

        public void AddStock(AddStockObj AddStock)
        {
            if (AddStock != null)
            {
                _Stockrepo.AddNew(AddStock);
            }            
        }

        public void DeleteStock(DeleteStockObj DeleteStock)
        {
            if (DeleteStock != null)
            {
                _Stockrepo.DeleteStock(DeleteStock);
            }
        }

        public IEnumerable<Stockobj> GetAll()
        {
            return _Stockrepo.GetAll();
        }

        public void UpdateStock(UpdateStockObj UpdateStock)
        {
            if (UpdateStock != null)
            {
                _Stockrepo.UpdateStock(UpdateStock);
            }
        }
    }
}