using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public IActionResult Employee()
        {
            return View();
        }
    }
}
