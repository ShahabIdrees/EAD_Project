using EAD_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EAD_Project.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ViewResult SignupForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignupForm(string Firstname, string Lastname, string Email, string Password)
        {
            
            SaveUser.SaveUserData(Firstname, Lastname, Email, Password);
            return View("LoginForm");
        }
        [HttpGet]
        public ViewResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult LoginForm(string Email, string Password)
        {
            if (ModelState.IsValid)
            {
                string ActualPass = SaveUser.getUserPassword(Email);
                if (ActualPass == Password)
                {
                    List<User> Users = new List<User>();
                    Users = SaveUser.getAllUsers();
                    return View("DashBoard", Users);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Please enter correct data");
                    return View("ErrorMessage");
                }
            }
            else
            {
                return View();
            }
            
        }
        public ViewResult ErrorMessage()
        {
            return View("LoginForm");
        }
        public ViewResult Home()
        {
            return View("Index");
        }
        
        
    }
}