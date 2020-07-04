using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AsianTravelAgency.Models;
using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Services;
using AsianTravelAgency.Models.ViewModels.PostViewModel;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace AsianTravelAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostService _service;
        private readonly IWebHostEnvironment _webEnvironment;

        public HomeController(ILogger<HomeController> logger, PostService _service, IWebHostEnvironment _webEnvironment)
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
                List<DisplayPostViewModel> ListOfPosts = Posts.ToList();
                return View(new DisplayAllPostViewModel() { Posts = ListOfPosts });
            }
            catch(Exception)
            {
                return BadRequest("Invalid request received!");
            }
        }

        //functie care intoarce un view pentru adaugat anunturi
       public IActionResult AddPost()
        {
            return View();
        }

        //functie care primeste datele dintr-un form si adauga un post
        [HttpPost]
        public IActionResult AddPost([FromForm] AddPostViewModel PostToAdd)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(PostToAdd);
                Post NewPost = new Post()
                {
                    Title = PostToAdd.Title,
                    Question = PostToAdd.Question,
                    ImageName = PostToAdd.Question
                };
                _service.AddPost(NewPost);
                return Redirect(Url.Action("Index", "Home"));
            }
            return BadRequest();
        }

        private string UploadedFile(AddPostViewModel PostToAdd)
        {
            string uniqueFileName = null;

            if (PostToAdd.ImageName != null)
            {
                string uploadsFolder = Path.Combine(_webEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + PostToAdd.ImageName.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    PostToAdd.ImageName.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        
        //functie care intoarce un view pentru stergerea unui anunt

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
