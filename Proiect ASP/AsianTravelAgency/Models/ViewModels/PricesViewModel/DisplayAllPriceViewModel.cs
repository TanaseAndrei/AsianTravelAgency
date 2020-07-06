using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PricesViewModel
{
    public class DisplayAllPriceViewModel
    {
        public IEnumerable<DisplayPriceViewModel> Prices { get; set; }
    }
}
