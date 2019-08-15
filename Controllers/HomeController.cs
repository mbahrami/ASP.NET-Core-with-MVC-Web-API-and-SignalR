using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClareSoft.Models;

namespace ClareSoft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }           

        public ActionResult WebApiTest()
        {
            var led1 = _context.Remote.Where(x => x.Name == "LED1").FirstOrDefault();  
            if (led1.Value == 1)
            {
                return View(true);
            }
            else
            {
                return View(false);
            }
           
        }
        
    }
}
