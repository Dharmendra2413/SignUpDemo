using Microsoft.AspNetCore.Mvc;
using SignUpDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpDemo.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View("AddSignUp", GetModel());
        }
        [NonAction]
        public SignUpModel GetModel()
        {
            List<string> city = new List<string>(){
                "Mumbai",
                "Pune",
                "Delhi",
                "Mysore"
            };
            SignUpModel signUpModel = new SignUpModel()
            { CityNames = city };
            return signUpModel;
        }
        [HttpPost]
        public IActionResult AddSignUp(SignUpModel signUpModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ShowMessage = signUpModel.UserName + ", Your Registration done sucessfully !!";
                return View("ViewMessage");
            }
            ViewBag.ShowMessage = signUpModel.UserName + ", Your Registration failed !!";
            return View("ViewMessage");
        }
    }
}
