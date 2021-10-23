using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_1.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class CartController: Controller
    {
        private static HashSet<int> _item = new HashSet<int>();
        private readonly Random _random = new Random();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await Task.Delay(8000);

            return Ok(_item);
        }


        [HttpPost]
        public IActionResult Add()
        {
            _item.Add(_random.Next(1000));

            return Ok(_item);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _item.Remove(_item.FirstOrDefault(x=> x > 100));
            return Ok(_item);
        }

    }
}
