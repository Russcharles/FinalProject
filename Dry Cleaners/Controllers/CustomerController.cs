using Dry_Cleaners.Models;
using Dry_Cleaners.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;

namespace Dry_Cleaners.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
       
        // GET: Customer
        public ActionResult New()
        {
            var dryCleanerStores = _context.DryCleanerStores.ToList();
            var kioskLocations = _context.KioskLocations.ToList();
            var membershipType = _context.MembershipType.ToList();
            var creditCardInfo = _context.CreditCardInfo.ToList();
            var viewModel = new NewCustomerViewModel
            {
                DryCleanerStores = dryCleanerStores,
                KioskLocations = kioskLocations,
                MembershipType = membershipType,
                CreditCardInfo = creditCardInfo
            };
            
            
            return View(viewModel);

        }
       
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            string AccountSid = "AC689c96cd8452e930c202a9dcce990a0a";
            string AuthToken = "c991d34dc4106be2225406d45785302f";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            twilio.SendMessage(
                "+13146359196 ", "+1" + customer.PhoneNumber, "Thank you for signing up!  You should be receive your personalized laundry bag with in 5-7 business days");
            return RedirectToAction("Index", "Customer");
        }
    }
}