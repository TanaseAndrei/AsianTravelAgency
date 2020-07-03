using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PostViewModel
{
    public class EditPostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Question { get; set; }

        public string ImageName { get; set; }
    }
}
