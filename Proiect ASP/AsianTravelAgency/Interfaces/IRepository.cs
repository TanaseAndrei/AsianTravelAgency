using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Interfaces
{
    public interface IRepository<T>
    {
        public T Add(T itemToAdd);
        public IEnumerable<T> GetAll();
        public T Update(T itemToUpdate);
        public bool Delete(T itemToDelete);
    }
}
