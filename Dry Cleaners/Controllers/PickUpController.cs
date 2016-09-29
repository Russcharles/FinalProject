using Dry_Cleaners.Models;
using Dry_Cleaners.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;

namespace Dry_Cleaners.Controllers
{
    public class PickUpController : Controller
    {
        public PickUp pickUp { get; set; }
        // GET: PickUp
        private ApplicationDbContext _context3;
        public PickUpController()
        {
            _context3 = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context3.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PickUp()
        {
            var viewmodel = new PickUpViewModel
            {
                PickUp = pickUp,
            };
            return View(viewmodel);
        }
        [HttpPost]
        public ActionResult Create(PickUp pickUp)
        {
            _context3.PickUp.Add(pickUp);
            _context3.SaveChanges();
            string AccountSid = "AC689c96cd8452e930c202a9dcce990a0a";
            string AuthToken = "c991d34dc4106be2225406d45785302f";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            twilio.SendMessage(
                "+13146359196 ", "+1" + pickUp.PhoneNumber, "Thank you for signing up!  You should be receive your personalized laundry bag with in 5-7 business days");
            return RedirectToAction("Index", "PickUp");
        }
    }
}