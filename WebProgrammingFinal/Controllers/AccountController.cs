using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProgrammingFinal.Model;
using Microsoft.AspNetCore.Http;

namespace WebProgrammingFinal.Controllers
{
    public class AccountController : Controller
    {
        // Loads up the database
        public static loginDbMod _context;

        public AccountController(loginDbMod context)
        {
            _context = context;
        }
        
        // Register Page
        public ActionResult Register()
        {
            return View();
        }

        // Register Function
        [HttpPost]
        public ActionResult Register(UserAccount user)
        {
            if (ModelState.IsValid)
            {
                var registered = _context.UserAccount.Where(u => u.Email == user.Email || u.Username == user.Username).FirstOrDefault();
                if (registered != null)
                {
                    ModelState.Clear();
                    ModelState.AddModelError("", "Email address in use");
                }
                else
                {
                    // Database updated here. ### duplicate issue ###
                    _context.UserAccount.Add(user);
                    _context.SaveChanges();

                    ModelState.Clear();
                    ViewBag.Message = user.Username + " has registered successfully.";
                }
            }
            return View();
        }

        // Login Page
        public ActionResult Login()
        {
            return View();
        }

        // Login Functtiton
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            var account = _context.UserAccount.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserID.ToString());
                HttpContext.Session.SetString("Username", account.Username);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is incorrect");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        
    }
}
