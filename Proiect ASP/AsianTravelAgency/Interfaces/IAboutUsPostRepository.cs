using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Interfaces
{
    public interface IAboutUsPostRepository : IRepository<AboutUsPost>
    {
        AboutUsPost GetPost(int id);
    }
}
