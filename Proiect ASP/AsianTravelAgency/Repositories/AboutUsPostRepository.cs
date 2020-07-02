using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Repositories
{
    public class AboutUsPostRepository : Repository<AboutUsPost>, IAboutUsPostRepository
    {
        public AboutUsPostRepository(AsianTravelAgencyContext _context) : base(_context) { }

        public AboutUsPost GetPost(int id)
        {
            return _context.AboutUsPostSet.Where(p => p.Id == id).SingleOrDefault();
        }

    }
}
