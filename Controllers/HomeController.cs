using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVP(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                GuestResponse.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult Thanks()
        {
            return View();
        }
        public ViewResult GuestsList()
        {
            return View("GuestsList", GuestResponse.GuestResponses.Where(x => x.WillAttend == true));
        }
    }
}
