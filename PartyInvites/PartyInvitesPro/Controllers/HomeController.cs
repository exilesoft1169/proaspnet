using PartyInvitesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvitesPro.Controllers
{
    public class HomeController : Controller
    {
        // GET: 
        [HttpGet]
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ActionResult RSVPFRM()
        {
            return View();
        }



        [HttpPost]
        public ActionResult RSVPFRM(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {

                // TODO: Email response to the party organizer

                return View("Thanks", guestResponse);

            }
            else
            {

                // there is a validation error

                return View();

            }
           // return View("Thanks",guestResponse);
        }
    }
}