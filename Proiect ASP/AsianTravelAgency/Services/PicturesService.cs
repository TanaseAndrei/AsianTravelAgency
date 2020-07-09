using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.PicturesViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Services
{
    public class PicturesService
    {
        private readonly IPicturesRepository _repository;

        public PicturesService(IPicturesRepository _repository)
        {
            this._repository = _repository;
        }

        public void AddPicture(Pictures Picture)
        {
            _repository.Add(Picture);
        }

        public void Delete(int id)
        {
            Pictures PictureToDelete = _repository.GetPicture(id);
            if(PictureToDelete == null)
            {
                //aruncare exceptie
            }
            _repository.Delete(PictureToDelete);
        }

        public DisplayPictureViewModel Get(int id)
        {
            Pictures AuxiliaryPicture = _repository.GetPicture(id);
            if(AuxiliaryPicture == null)
            {
                //aruncare exceptie
            }
            DisplayPictureViewModel PictureToReturn = new DisplayPictureViewModel()
            {
                Id = AuxiliaryPicture.Id,
                PictureName = AuxiliaryPicture.PictureName,
                Country = AuxiliaryPicture.Country
            };
            return PictureToReturn;
        }

        public IEnumerable<DisplayPictureViewModel> GetAll()
        {
            IList<DisplayPictureViewModel> ListOfPictures = new List<DisplayPictureViewModel>();
            foreach(var Picture in _repository.GetAll())
            {
                DisplayPictureViewModel PictureToDisplay = new DisplayPictureViewModel()
                {
                    Id = Picture.Id,
                    PictureName = Picture.PictureName,
                    Country = Picture.Country
                };
                ListOfPictures.Add(PictureToDisplay);
            }
            return ListOfPictures;
        }

        public HashSet<string> GetCountriesOfAllPictures()
        {
            HashSet<string> Countries = new HashSet<string>();
            List<Pictures> ListOfPictures = _repository.GetAll().ToList();
            foreach(Pictures Picture in ListOfPictures)
            {
                Countries.Add(Picture.Country);
            }
            return Countries;
        }

    }
}
