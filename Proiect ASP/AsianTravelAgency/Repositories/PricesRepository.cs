using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Repositories
{
    public class PricesRepository : Repository<Prices>, IPricesRepository
    {
        public PricesRepository(AsianTravelAgencyContext _context) : base(_context) { }

        public Prices GetPrices(int id)
        {
            return _context.PriceSet.Where(p => p.Id == id).SingleOrDefault();
        }

    }
}
