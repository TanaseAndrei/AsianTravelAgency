using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.AboutUsPostViewModel;
using AsianTravelAgency.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AsianTravelAgency.Controllers
{
    public class AboutUsPostsController : Controller
    {
        private readonly ILogger<AboutUsPostsController> _logger;
        private readonly AboutUsPostService _service;
        private readonly IWebHostEnvironment _webEnvironment;

        public AboutUsPostsController(ILogger<AboutUsPostsController> logger, AboutUsPostService _service, IWebHostEnvironment _webEnvironment)
        {
            _logger = logger;
            this._service = _service;
            this._webEnvironment = _webEnvironment;
        }

        //functie care intoarce view cu pagina principala si toate posturile
        //extragem posturile cu PostService
        //cream un ViewModel care contine o lista de Posturi
        //afisam datele in view pentru fiecare post
        public IActionResult Index()
        {
            try
            {
                var Posts = _service.GetAll();
                return View(new DisplayAllAboutUsPostViewModel() { AllAboutUsPosts = Posts.AsEnumerable() });
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }

        //functie care intoarce un view pentru adaugat anunturi
        public IActionResult AddPost()
        {
            return View();
        }

        //functie care primeste datele dintr-un form si adauga un post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPost([FromForm] AddAboutUsPostViewModel PostToAdd)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(PostToAdd);
                AboutUsPost NewPost = new AboutUsPost()
                {
                    Title = PostToAdd.Title,
                    Content = PostToAdd.Content,
                    ImageTitle = uniqueFileName
                };
                _service.AddPost(NewPost);
                return Redirect(Url.Action("Index", "AboutUsPosts"));
            }
            return BadRequest();
        }

        //functie care intoarce un view pentru stergerea unui anunt
        [HttpGet]
        public IActionResult Delete(int id)
        {
            DisplayAboutUsPostViewModel PostToDelete = _service.GetPost(id);
            return View(PostToDelete);
        }

        //functie care sterge elementul respectiv
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.DeletePost(id);
            return Redirect(Url.Action("Index", "AboutUsPosts"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string UploadedFile(AddAboutUsPostViewModel PostToAdd)
        {
            string uniqueFileName = null;

            if (PostToAdd.ImageTitle != null)
            {
                string uploadsFolder = Path.Combine(_webEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + PostToAdd.ImageTitle.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    PostToAdd.ImageTitle.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
