using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebProgrammingFinal.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Animals()
        {
            return View();
        }
    }
}