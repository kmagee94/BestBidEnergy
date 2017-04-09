using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestBidEnergy.Data;
using Microsoft.AspNetCore.Mvc;
using BestBidEnergy.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BestBidEnergy.Controllers
{
    public class BuyersController : Controller
    {
       BestBidEnergyContext db = new BestBidEnergyContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            var buyers = db.Buyer.ToList();
            //var buyers = new buyer{Username = "Mike"};
            return View(buyers);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Contracts()
        {
            return View();
        }
    }
}
