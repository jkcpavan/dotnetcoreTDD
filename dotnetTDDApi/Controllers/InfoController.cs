using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetTDDApi.DAO;
using Microsoft.AspNetCore.Mvc;

namespace dotnetTDDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{first}")]
        public ActionResult<string> getLastName(string first)
        {
            return new LastNameDAO().GetLastName(first).LastName;
        }
    }
}
