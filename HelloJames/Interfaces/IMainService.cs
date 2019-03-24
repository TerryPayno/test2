using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedObject3.SharedObjects.Recipe;

namespace HelloJames.Interfaces
{
    public interface IMainService
    {
        IEnumerable<RecipeObj> GetAllInfo();
    }
}
