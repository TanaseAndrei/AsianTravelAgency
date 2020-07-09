using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.FAQViewModel
{
    public class EditFAQViewModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
