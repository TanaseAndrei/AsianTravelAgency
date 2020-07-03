using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PostViewModel
{
    public class DisplayAllPostViewModel
    {
        public IEnumerable<DisplayPostViewModel> Posts { get; set; }
    }
}
