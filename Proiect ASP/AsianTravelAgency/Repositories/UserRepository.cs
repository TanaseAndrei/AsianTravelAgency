using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AsianTravelAgencyContext _context) : base(_context) { }

        public User GetUser(int id)
        {
            return _context.UserSet.Where(u => u.Id == id).SingleOrDefault();
        }
    }
}
