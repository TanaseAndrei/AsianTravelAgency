using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PicturesViewModel
{
    public class DisplayAllPictureViewModel
    {
        public IEnumerable<DisplayPictureViewModel> Pictures { get; set; }
        public HashSet<string> Countries { get; set; }
    }
}
