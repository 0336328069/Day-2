using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{

    public class LoginController : Controller
    {
        private static readonly List<User> users = new List<User>()
        {
            new User()
            {
                username = "admin",
                password = "admin",
                email = "admin@admin"
            },
            new User()
            {
                username = "admin2",
                password = "admin2",
                email = "admin2@admin"
            }
        };
       
        public IActionResult Index()
        {
            List<User> u = users;
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login(UserViewModel model)
        {
            foreach(var u in users)
            {
                if(u.password == model.password && u.username == model.username)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return   RedirectToAction("Index", "Login"); ;
        }
        public IActionResult Register(RegisterViewModel model)
        {
            foreach(var u in users)
            {
                if(model.username == u.username || model.password != model.repeatpassword)
                { 
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    var us = new User()
                    {
                        username = model.username,
                        email = "",
                        password = model.password
                    };
                    users.Add(us);
                    break;
                }
            }
            return RedirectToAction("Index", "Home", users);
        }
    }
}
