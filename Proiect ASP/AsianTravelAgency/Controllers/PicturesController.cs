using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.PicturesViewModel;
using AsianTravelAgency.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Controllers
{
    public class PicturesController : Controller
    {
        private readonly PicturesService _service;
        private readonly IWebHostEnvironment _webEnvironment;
        public PicturesController(PicturesService _service, IWebHostEnvironment _webEnvironment)
        {
            this._service = _service;
            this._webEnvironment = _webEnvironment;
        }
        
        public IActionResult Index()
        {
            var AllPictures = _service.GetAll();
            List<DisplayPictureViewModel> ListOfPictures = AllPictures.ToList();
            var Countries = _service.GetCountriesOfAllPictures();
            HashSet<string> AllCountries = Countries.ToHashSet();
            return View(new DisplayAllPictureViewModel() { Pictures = ListOfPictures, Countries = AllCountries});
        }

        public IActionResult AddPicture()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPicture([FromForm] AddPictureViewModel PictureToAdd)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(PictureToAdd);
                Pictures Picture = new Pictures()
                {
                    PictureName = uniqueFileName,
                    Country = PictureToAdd.Country
                };
                _service.AddPicture(Picture);
                return Redirect(Url.Action("Index", "Pictures"));
            }
            return BadRequest();
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Redirect(Url.Action("Index", "Pictures"));
        }

        private string UploadedFile(AddPictureViewModel PictureToAdd)
        {
            string uniqueFileName = null;

            if (PictureToAdd.ImageTitle != null)
            {
                string uploadsFolder = Path.Combine(_webEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + PictureToAdd.ImageTitle.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    PictureToAdd.ImageTitle.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
