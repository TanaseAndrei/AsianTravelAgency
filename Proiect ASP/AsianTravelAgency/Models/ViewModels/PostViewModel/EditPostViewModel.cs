﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PostViewModel
{
    public class EditPostViewModel
    {
        public string Title { get; set; }

        public string Question { get; set; }

        public IFormFile ImageName { get; set; }
    }
}
