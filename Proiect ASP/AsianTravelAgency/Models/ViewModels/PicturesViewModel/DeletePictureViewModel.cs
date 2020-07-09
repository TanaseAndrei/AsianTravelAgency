using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PicturesViewModel
{
    public class DeletePictureViewModel
    {
        public int Id { get; set; }
        public string PictureName { get; set; }

        public string Country { get; set; }
    }
}
