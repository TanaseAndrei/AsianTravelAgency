using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Interfaces
{
    interface IAboutUsPostRepository<AboutUsPost>
    {
        AboutUsPost GetPost(int id);
    }
}
