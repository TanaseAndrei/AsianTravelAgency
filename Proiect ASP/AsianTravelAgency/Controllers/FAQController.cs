using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Models;
using AsianTravelAgency.Models.ViewModels.FAQViewModel;
using AsianTravelAgency.Services;
using Microsoft.AspNetCore.Mvc;

namespace AsianTravelAgency.Controllers
{
    public class FAQController : Controller
    {
        private readonly FAQService _service;

        public FAQController(FAQService _service)
        {
            this._service = _service;
        }

        //functie care intoarce un view cu toate intrebarile si raspunsurile
        public IActionResult Index()
        {
            var FAQs = _service.GetAll();
            List<DisplayFAQViewModel> ListOfAllFAQs = FAQs.ToList();
            return View(new DisplayAllFAQViewModel() { FAQs = ListOfAllFAQs});
        }

        public IActionResult AddFAQ()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddFAQ([FromForm]AddFAQViewModel ModelToAdd)
        {
            if (ModelState.IsValid)
            {
                FAQ FAQFromModel = new FAQ()
                {
                    Question = ModelToAdd.Question,
                    Answer = ModelToAdd.Answer
                };
                _service.AddFAQ(FAQFromModel);
                return Redirect(Url.Action("Index", "FAQ"));
            } else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            DisplayFAQViewModel FAQToDelete = _service.Get(id);
            return View(FAQToDelete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return Redirect(Url.Action("Index", "FAQ"));
        }
            public IActionResult Edit(int id)
            {
                DisplayFAQViewModel ModelToEdit = _service.Get(id);
                return View(ModelToEdit);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit([FromForm] EditFAQViewModel PriceToEdit)
            {
                if (ModelState.IsValid)
                {
                    FAQ FAQToUpdate = new FAQ()
                    {
                       Id = PriceToEdit.Id,
                       Question = PriceToEdit.Question,
                       Answer = PriceToEdit.Answer
                    };
                    _service.Edit(FAQToUpdate);
                    return Redirect(Url.Action("Index", "FAQ"));
                }
                return BadRequest();
            }
        }

 }

