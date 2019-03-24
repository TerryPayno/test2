using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Stock;
using System.Collections.Generic;

namespace HelloJames.Interfaces
{
    public interface IStockService
    {
        void AddStock(AddStockObj AddStock);
        void UpdateStock(UpdateStockObj UpdateStock);
        void DeleteStock(DeleteStockObj DeleteStock);
        IEnumerable<Stockobj> GetAll();
    }
}
