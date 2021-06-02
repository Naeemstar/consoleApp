using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coremvc4_apps.Models;
using Microsoft.AspNetCore.Mvc;

namespace coremvc4_apps.Controllers
{
    public class homeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult detail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult detail(employee emp)
        {
            if (ModelState.IsValid)
            {
               
                
                
            }
            return View();
        }

        public IActionResult create()
        {
            
            return View();
        }
    }
}