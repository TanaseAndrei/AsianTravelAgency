using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.FAQViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Services
{
    public class FAQService
    {
        private readonly IFAQRepository _repository;

        public FAQService(IFAQRepository _repository)
        {
            this._repository = _repository;
        }

        public void AddFAQ(FAQ FAQToAdd)
        {
            _repository.Add(FAQToAdd);
        }

        public DisplayFAQViewModel Get(int id)
        {
            FAQ ReturnedFAQ = _repository.GetFAQ(id);

            if(ReturnedFAQ == null)
            {
                //aruncare exceptie
            }

            DisplayFAQViewModel FAQToDisplay = new DisplayFAQViewModel()
            {
                Id = ReturnedFAQ.Id,
                Question = ReturnedFAQ.Question,
                Answer = ReturnedFAQ.Answer
            };

            return FAQToDisplay;
        }

        public void Delete(int id)
        {
            var FAQ = _repository.GetFAQ(id);
            if(FAQ == null)
            {
                //aruncare exceptie
            }
            _repository.Delete(FAQ);
        }

        public void Edit(FAQ FAQToUpdate)
        {
            _repository.Update(FAQToUpdate);
        }

        public IEnumerable<DisplayFAQViewModel> GetAll()
        {
            var AllFAQs = _repository.GetAll();
            List<DisplayFAQViewModel> ListOfAllFAQs = new List<DisplayFAQViewModel>();
            foreach (var FAQ in AllFAQs)
            {
                DisplayFAQViewModel ModelToAddToList = new DisplayFAQViewModel()
                {
                    Id = FAQ.Id,
                    Question = FAQ.Question,
                    Answer = FAQ.Answer
                };
                ListOfAllFAQs.Add(ModelToAddToList);
            }
            return ListOfAllFAQs;
        }

    }
}
