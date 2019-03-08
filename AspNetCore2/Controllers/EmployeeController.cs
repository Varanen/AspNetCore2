using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore2.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public string Index()
        {
            return "Hello, from Employee";
        }
        public ContentResult Name()
        {
            return Content("Lukas");
        }
        public string Country()
        {
            return "Sweden";
        }
    }
}
