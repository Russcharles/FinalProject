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
    public class OrderController : Controller
    {   public Order order { get; set; }
        // GET: Order
        private ApplicationDbContext _context2;
        public OrderController()
        {
            _context2 = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context2.Dispose();
        }
        public ActionResult Index()
        {   
            return View();
        }
        public ActionResult PlaceOrder()
        {
            var viewmodel = new OrderViewModel
            {
                Order = order,
            };
            return View(viewmodel);
        }
        [HttpPost]
        public ActionResult Create(Order order)
        {
            _context2.Order.Add(order);
            _context2.SaveChanges();
            string AccountSid = "AC689c96cd8452e930c202a9dcce990a0a";
            string AuthToken = "c991d34dc4106be2225406d45785302f";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            twilio.SendMessage(
                "+13146359196 ", "+1" + order.PhoneNumber, "Thank you for signing up!  You should be receive your personalized laundry bag with in 5-7 business days");
            
            return RedirectToAction("Index", "Order");
        }

    }
}