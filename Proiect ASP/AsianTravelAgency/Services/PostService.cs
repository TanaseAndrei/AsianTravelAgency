using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.PostViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AsianTravelAgency.Services
{
    public class PostService
    {
        private IPostRepository _repository;
        public PostService(IPostRepository _repository)
        {
            this._repository = _repository;
        }

        public void AddPost(AddPostViewModel ItemToAdd)
        {
            _repository.Add(new Post()
            {
                Title = ItemToAdd.Title,
                Question = ItemToAdd.Question,
                ImageName = ItemToAdd.ImageName
            });
        }

        public void DeletePost(int ItemId)
        {
            var Post = _repository.GetPost(ItemId);
            if(Post == null)
            {
                //aruncare exceptie
            }
            _repository.Delete(Post);
        }

        public IEnumerable<DisplayPostViewModel> GetAll()
        {
            List<DisplayPostViewModel> List = new List<DisplayPostViewModel>();
            foreach(var Post in _repository.GetAll())
            {
                List.Add(new DisplayPostViewModel()
                {
                    Id = Post.Id,
                    Title = Post.Title,
                    Question = Post.Question,
                    ImageName = Post.ImageName
                });
            }
            return List;
        }

    }
}
