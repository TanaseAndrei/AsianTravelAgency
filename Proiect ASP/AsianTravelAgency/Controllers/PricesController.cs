using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsianTravelAgency;
using AsianTravelAgency.Models;
using Microsoft.Extensions.Logging;
using AsianTravelAgency.Services;
using AsianTravelAgency.Models.ViewModels.PricesViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AsianTravelAgency.Models.ViewModels.PostViewModel;

namespace AsianTravelAgency.Controllers
{
    public class PricesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PricesService _service;

        public PricesController(ILogger<HomeController> _logger, PricesService _service)
        {
            this._logger = _logger;
            this._service = _service;
        }

        public IActionResult Index()
        {
            var Prices = _service.GetAll();
            List<DisplayPriceViewModel> ListOfPosts = Prices.ToList();
            return View(new DisplayAllPriceViewModel() { Prices = ListOfPosts });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPrice([FromForm] AddPriceViewModel ModelToAdd)
        {
            if (ModelState.IsValid)
            {
                Prices PriceToAdd = new Prices()
                {
                    Destination = ModelToAdd.Destination,
                    OnePersonPrice = ModelToAdd.OnePersonPrice,
                    TwoPersonsPrice = ModelToAdd.TwoPersonsPrice,
                    ThreePersonsPrice = ModelToAdd.ThreePersonsPrice,
                    SendingWay = ModelToAdd.SendingWay,
                    TicketType = ModelToAdd.TicketType,
                    Guiding = ModelToAdd.Guiding,
                    LeavingFrom = ModelToAdd.LeavingFrom,
                    TripInfo = ModelToAdd.TripInfo

                };
                _service.AddPrice(PriceToAdd);
                return Redirect(Url.Action("Index", "PricesController"));
            }
            return BadRequest();
        }

        //functie care intoarce un view pentru stergere
        public IActionResult Delete(int id)
        {
            DisplayPriceViewModel PriceToDisplayForDelete = _service.GetPrice(id);
            return View(PriceToDisplayForDelete);
        }

        //functie care sterge elementul respectiv, dupa apasarea butonului de submit
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.DeletePrice(id);
            return Redirect(Url.Action("Index", "Home"));
        }

    }
}
