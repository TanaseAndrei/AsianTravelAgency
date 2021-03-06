﻿using AsianTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUser(int id);
    }
}
