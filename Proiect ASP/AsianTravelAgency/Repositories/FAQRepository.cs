using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Repositories
{
    public class FAQRepository : Repository<FAQ>, IFAQRepository
    {
        public FAQRepository(AsianTravelAgencyContext _context) : base(_context) { }

        public FAQ GetFAQ(int id)
        {
            return _context.FAQSet.Where(f => f.Id == id).SingleOrDefault();
        }

    }
}
