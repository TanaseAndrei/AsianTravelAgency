using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AsianTravelAgencyContext _context) : base(_context) { }

        public Post GetPost(int id)
        {
            return _context.PostSet.Where(p => p.Id == id).SingleOrDefault();
        }
    }
}
