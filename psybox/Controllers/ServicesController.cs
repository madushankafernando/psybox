using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace psybox.Controllers
{
    public class ServicesController : Controller
    {
        // GET: /<controller>/
        public IActionResult ESDevelopment()
        {
            return View();
        }

        public IActionResult ITConsulting()
        {
            return View();
        }

        public IActionResult DataExtraction()
        {
            return View();
        }

        public IActionResult AInML()
        {
            return View();
        }

        public IActionResult MADevelopment()
        {
            return View();
        }

        public IActionResult WDevelopment()
        {
            return View();
        }
    }
}
