﻿using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Post GetPost(int id);
    }
}
