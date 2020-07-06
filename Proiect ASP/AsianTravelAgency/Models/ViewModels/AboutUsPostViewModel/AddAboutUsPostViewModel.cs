using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.AboutUsPostViewModel
{
    public class AddAboutUsPostViewModel
    {

        public string Title { get; set; }

        public string Content { get; set; }

        public IFormFile ImageTitle { get; set; }
    }
}
