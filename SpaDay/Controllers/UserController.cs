using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
[Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user/")]
        public IActionResult SubmitAddUserForm(User newUser , string varify)
        {
            if (newUser.Password == varify)
            {
                ViewBag.SpaUser = newUser.UserName;
                ViewBag.email = newUser.Email;
                ViewBag.date = newUser.Date;
                return View("Index");
            }

            else
            {
                ViewBag.username = newUser.UserName;
                ViewBag.email = newUser.Email;
                ViewBag.error = "PassWord Did not match. Enter Again";
                return View("Add");
            }
           
        }
    }
    
}
