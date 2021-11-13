using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using psybox.Models;

namespace psybox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult faq()
        {
            return View();
        }

        public IActionResult WhyChooseUs()
        {
            return View();
        }

        public IActionResult LeaderShip()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Awards()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
