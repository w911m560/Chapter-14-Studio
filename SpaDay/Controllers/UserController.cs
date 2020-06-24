using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // Get: /user
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Get: /user/add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Post: /user
        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            if (newUser.Password == verify)
            {
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match";
                return View("Add");
            }
        }
    }
}
