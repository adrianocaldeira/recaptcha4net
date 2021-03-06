﻿using System.Web.Mvc;
using Recaptcha4Net;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var recaptchaResponse = Recaptcha.Verify();

            if (!recaptchaResponse.Success)
            {
                ModelState.AddModelError("Recaptcha", "Informe que você não é um robô clicando no quadro do reCAPTCHA");
            }
            
            return View();
        }
    }
}