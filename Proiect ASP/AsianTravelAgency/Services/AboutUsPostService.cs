using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.AboutUsPostViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Services
{
    public class AboutUsPostService
    {
        private readonly IAboutUsPostRepository _repository;
        public AboutUsPostService(IAboutUsPostRepository _repository)
        {
            this._repository = _repository;
        }

        public void AddPost(AboutUsPost ItemToAdd)
        {
            _repository.Add(ItemToAdd);
        }

        public void DeletePost(int ItemId)
        {
            var AboutUsPostToBeDeleted = _repository.GetPost(ItemId);
            if (AboutUsPostToBeDeleted == null)
            {
                //aruncare exceptie
            }
            _repository.Delete(AboutUsPostToBeDeleted);
        }

        public IEnumerable<DisplayAboutUsPostViewModel> GetAll()
        {
            List<DisplayAboutUsPostViewModel> List = new List<DisplayAboutUsPostViewModel>();
            foreach (var AboutUsPost in _repository.GetAll())
            {
                List.Add(new DisplayAboutUsPostViewModel()
                {
                    Id = AboutUsPost.Id,
                    Title = AboutUsPost.Title,
                    Content = AboutUsPost.Content,
                    ImageName = AboutUsPost.ImageTitle
                });
            }
            return List;
        }

        public DisplayAboutUsPostViewModel GetPost(int id)
        {
            var AboutUsPost = _repository.GetPost(id);
            DisplayAboutUsPostViewModel PostToReturn = new DisplayAboutUsPostViewModel()
            {
                Id = AboutUsPost.Id,
                Title = AboutUsPost.Title,
                Content = AboutUsPost.Content,
                ImageName = AboutUsPost.ImageTitle
            };
            return PostToReturn;
        }
    }
}
