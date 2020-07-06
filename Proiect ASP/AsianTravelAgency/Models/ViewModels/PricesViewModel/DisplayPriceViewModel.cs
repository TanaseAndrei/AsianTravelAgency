using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Models.ViewModels.PricesViewModel
{
    public class DisplayPriceViewModel
    {
        public int Id { get; set; }

        public string Destination { get; set; }

        public int OnePersonPrice { get; set; }

        public int TwoPersonsPrice { get; set; }

        public int ThreePersonsPrice { get; set; }

        public string SendingWay { get; set; }

        public string TicketType { get; set; }

        public string Guiding { get; set; }

        public string LeavingFrom { get; set; }

        public string TripInfo { get; set; }
    }
}
