using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T itemToAdd);
        IEnumerable<T> GetAll();
        T Update(T itemToUpdate);
        bool Delete(T itemToDelete);
    }
}
