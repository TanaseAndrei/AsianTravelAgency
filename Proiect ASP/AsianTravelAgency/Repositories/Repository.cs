using AsianTravelAgency.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AsianTravelAgency.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {

        protected readonly AsianTravelAgencyContext _context;

        public Repository(AsianTravelAgencyContext _context)
        {
            this._context = _context;
        }

        public T Add(T itemToAdd)
        {
            var item = _context.Add<T>(itemToAdd);
            _context.SaveChanges();
            return item.Entity;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public T Update(T itemToUpdate)
        {
            var entity = _context.Update<T>(itemToUpdate);
            _context.SaveChanges();
            return entity.Entity;
        }

        public bool Delete(T itemToDelete)
        {
            _context.Remove<T>(itemToDelete);
            _context.SaveChanges();
            return true;
        }

    }
}
