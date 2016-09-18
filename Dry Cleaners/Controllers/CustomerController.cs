using Dry_Cleaners.Models;
using Dry_Cleaners.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
    }
}