using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            
             return View();
        
        }

        public IActionResult Add()
        {
            AddUserViewModel objectName = new AddUserViewModel();
            return View(objectName);
        }

        [HttpPost]
        [Route("/user")]
        //public IActionResult SubmitAddUserForm(User newUser, string verify)

        public IActionResult SubmitAddUserForm(AddUserViewModel objectName)
        {

            if (ModelState.IsValid)
            {

                //if (objectName.Password == objectName.VarifyPassword)
                //{
                // ViewBag.user = newUser;
                User newUser = new User
                {
                    Username = objectName.Username,
                    Password = objectName.Password,
                    VarifyPassword = objectName.VarifyPassword,
                    Email = objectName.Email


                };

                return View("Index", newUser);
            }
            //    //}
            //    //else
            //    //{
            //        //ViewBag.error = "Passwords do not match! Try again!";
            //        //ViewBag.userName = newUser.Username;
            //        //ViewBag.eMail = newUser.Email;
            //        return View("Add",objectName);
            ////    }
           // }
            return View("Add",objectName);

        }

    }
}
