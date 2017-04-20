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
            ViewData["Message"] = "Click on an image to view the animals that are available";

            return View();
        }

        public IActionResult Cats()
        {
            ViewData["Message"] = "These are the Cats currently available";

            return View();
        }

        public IActionResult Dogs()
        {
            ViewData["Message"] = "These are the Dogs currently available";

            return View();
        }

        public IActionResult SmallAnimals()
        {
            ViewData["Message"] = "These are the Small Animals currently available ";

            return View();
        }

        public IActionResult Reptiles()
        {
            ViewData["Message"] = "These are the Reptiles currently available";

            return View();
        }
    }
}