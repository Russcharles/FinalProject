using Dry_Cleaners.Models;
using Dry_Cleaners.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return RedirectToAction("Index", "Order");
        }

    }
}