using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedObject3.SharedObjects;
using SharedObject3.SharedObjects.Stock;

namespace HelloJames.Interfaces
{
    public interface IStockRepo
    {
        void AddNew(AddStockObj newStock);
        void UpdateStock(UpdateStockObj UpdateStock);
        void DeleteStock(DeleteStockObj DeleteStock);
        IEnumerable<Stockobj> GetAll();
    }
}
