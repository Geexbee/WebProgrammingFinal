using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProgrammingFinal.Model;

namespace WebProgrammingFinal.Controllers
{
    public class HomeController : Controller
    {
        // eurgh do i really need to do this twice?
        public static loginDbMod _context;

        public HomeController(loginDbMod context)
        {
            _context = context;
        }

        // Index Page
        public IActionResult Index()
        {
            // Currently returning a list of registered users.
            return View(_context.UserAccount.ToList());
        }

        // About Pageg
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // Contact Page
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        // Logout function
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // Error Catcher
        public IActionResult Error()
        {
            return View();
        }
    }
}
