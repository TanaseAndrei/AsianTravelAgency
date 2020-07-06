using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.AboutUsPostViewModel
{
    public class DisplayAllAboutUsPostViewModel
    {
        public IEnumerable<DisplayAboutUsPostViewModel> AllAboutUsPosts { get; set; }
    }
}
