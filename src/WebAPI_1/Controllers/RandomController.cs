using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_1.Controllers
{
    //[ApiController]
    public class RandomController: Controller
    {
        private readonly Random _random = new Random();

        public IActionResult Index()
        {
            char rnd = (char)_random.Next('a',100);
            return Ok(rnd);
        }
        
    }
}
