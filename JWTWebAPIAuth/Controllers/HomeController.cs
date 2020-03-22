using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace JWTWebAPIAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var hmac = new HMACSHA256();
            var key = Convert.ToBase64String(hmac.Key);
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
