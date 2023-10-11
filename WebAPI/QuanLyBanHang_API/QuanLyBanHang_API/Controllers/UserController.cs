using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace QuanLyBanHang_API.Controllers
{
    public class UserController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //var rng = new random();
            //return enumerable.range(1, 5).select(index => new weatherforecast
            //{
            //    date = datetime.now.adddays(index),
            //    temperaturec = rng.next(-20, 55),
            //    summarry = summaries[rng.next(summaries.length)]
            //})
            //    .toarray();
            return null;
        }
    }
}

