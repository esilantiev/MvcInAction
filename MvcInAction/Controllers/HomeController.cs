using FluentValidation.Results;
using MvcInAction.Models;
using MvcInAction.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcInAction.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.SomeProperty = new string[]{"apple", "ananas", "banana"};
            return View();
        }

        [HttpGet]
        public ViewResult GuestForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult GuestForm(GuestResponseModel guestResponse)
        {
            var validator = new GuestResponseValidator();
            var results = validator.Validate(guestResponse);

            if (!ModelState.IsValid)
            {
                foreach (ValidationFailure failer in results.Errors)
                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                }

                return View();
            }

            return View("Thanks", guestResponse);
        }
    }
}