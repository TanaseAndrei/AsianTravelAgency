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

namespace AsianTravelAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostService _service;

        public HomeController(ILogger<HomeController> logger, PostService _service)
        {
            _logger = logger;
            this._service = _service;
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
        
        //functie care intoarce un view pentru stergerea unui anunt

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
