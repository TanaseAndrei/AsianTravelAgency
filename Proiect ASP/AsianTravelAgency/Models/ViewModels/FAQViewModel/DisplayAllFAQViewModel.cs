using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.FAQViewModel
{
    public class DisplayAllFAQViewModel
    {
        public IEnumerable<DisplayFAQViewModel> FAQs { get; set; }
    }
}
