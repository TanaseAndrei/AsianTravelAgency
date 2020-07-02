using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Repositories
{
    public class PicturesRepository : Repository<Pictures>, IPicturesRepository
    {
        public PicturesRepository(AsianTravelAgencyContext _context) : base(_context) { }

        public Pictures GetPictures(int id)
        {
            return _context.PictureSet.Where(p => p.Id == id).SingleOrDefault();
        }

    }
}
