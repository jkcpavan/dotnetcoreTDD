using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetTDDApi.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetTDDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{location}")]
        public ActionResult<string> getLastName(int location)
        {
            int[] i = { 10, 20, 30, 40 };
            return "Temperature is" + i[location];
        }
    }
}