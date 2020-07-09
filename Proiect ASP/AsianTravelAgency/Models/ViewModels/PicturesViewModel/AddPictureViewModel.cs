using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PicturesViewModel
{
    public class AddPictureViewModel
    {
        public string Country { get; set; }
        public IFormFile ImageTitle { get; set; }
    }
}
