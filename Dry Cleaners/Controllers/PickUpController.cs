using Dry_Cleaners.Models;
using Dry_Cleaners.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return RedirectToAction("Index", "PickUp");
        }
    }
}