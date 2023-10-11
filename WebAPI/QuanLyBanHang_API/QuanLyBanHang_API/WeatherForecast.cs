using System.Runtime.InteropServices;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;

namespace QuanLyBanHang_API
{
    public class WeatherForecast
    {
        public DateTime Data { get; set; }

        public int TemperatureC { get; set; }
        
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summarry { get; set;}
        public DateTime Date { get; internal set; }
        //public DateTime Date { get; internal set; }
    }
}
