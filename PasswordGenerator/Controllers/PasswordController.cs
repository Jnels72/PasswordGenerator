using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using System;
using System.Globalization;

namespace PasswordGenerator.Controllers
{
    public class PasswordController : Controller
    {
        public IActionResult Index()
        {
            PasswordModel rndPassword = new PasswordModel();
            return View(rndPassword);
        }

        [HttpPost]
        public IActionResult GenerateAlphaNumericPWD(PasswordModel passwordModel)
        {
            Random random = new Random();
            string passwordString = "";
            int minChars = 33;   
            int maxChars = 126;

            for (int i = 0; i < passwordModel.passwordLength; i++)
            {
                int temp = random.Next(minChars, maxChars);
                char letter = Convert.ToChar(temp);
                passwordString = passwordString + letter;
            }
            passwordModel.rndPassword = passwordString;
            return View("Index", passwordModel);
        }
        
    }
}
