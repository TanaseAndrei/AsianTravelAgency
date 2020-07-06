using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.PricesViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Services
{
    public class PricesService
    {
        private readonly IPricesRepository _repository;
        public PricesService(IPricesRepository _repository)
        {
            this._repository = _repository;
        }
        
        public void AddPrice(Prices PriceToAdd)
        {
            _repository.Add(PriceToAdd);
        }

        public void DeletePrice(int id)
        {
            var Prices = _repository.GetPrices(id);
            if(Prices == null)
            {
                //aruncare exceptie
            }
            _repository.Delete(Prices);
        }

        public DisplayPriceViewModel GetPrice(int id)
        {
            Prices OriginalPrice = _repository.GetPrices(id);
            DisplayPriceViewModel ModelToReturn = new DisplayPriceViewModel()
            {
                Id = OriginalPrice.Id,
                Destination = OriginalPrice.Destination,
                OnePersonPrice = OriginalPrice.OnePersonPrice,
                TwoPersonsPrice = OriginalPrice.TwoPersonsPrice,
                ThreePersonsPrice = OriginalPrice.ThreePersonsPrice,
                SendingWay = OriginalPrice.SendingWay,
                TicketType = OriginalPrice.TicketType,
                Guiding = OriginalPrice.Guiding,
                LeavingFrom = OriginalPrice.LeavingFrom,
                TripInfo = OriginalPrice.TripInfo
            };
            return ModelToReturn;
        }

        public IEnumerable<DisplayPriceViewModel> GetAll()
        {
            var AllPrices = _repository.GetAll();
            List<DisplayPriceViewModel> ListOfAllPrices = new List<DisplayPriceViewModel>();
            foreach(var Price in AllPrices)
            {
                DisplayPriceViewModel ModelToAddToList = new DisplayPriceViewModel()
                {
                    Id = Price.Id,
                    Destination = Price.Destination,
                    OnePersonPrice = Price.OnePersonPrice,
                    TwoPersonsPrice = Price.TwoPersonsPrice,
                    ThreePersonsPrice = Price.ThreePersonsPrice,
                    SendingWay = Price.SendingWay,
                    TicketType = Price.TicketType,
                    Guiding = Price.Guiding,
                    LeavingFrom = Price.LeavingFrom,
                    TripInfo = Price.TripInfo
                };
                ListOfAllPrices.Add(ModelToAddToList);
            }
            return ListOfAllPrices;
        }

        public void Edit(Prices PriceToUpdate)
        {
            _repository.Update(PriceToUpdate);
        }
    }
}
