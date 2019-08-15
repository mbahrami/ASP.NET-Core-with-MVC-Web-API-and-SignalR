using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClareSoft.Models;

namespace ClareSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LED1Controller : ControllerBase
    {

        private readonly ApplicationContext _context;

        public LED1Controller(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/LED1
        [HttpGet]
        public int Get()
        {
            Remote led1 = _context.Remote.Where(x => x.Name == "LED1").FirstOrDefault();
            return led1.Value;
        }

        [HttpPut]
        public void Put(Remote remote)
        {
            Remote led1 = _context.Remote.Where(x => x.Name == "LED1").FirstOrDefault();
            led1.Value = remote.Value;
            _context.SaveChanges();
        }
    }
}
