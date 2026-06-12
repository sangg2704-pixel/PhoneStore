using Microsoft.AspNetCore.Mvc;
using Phoneshop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
namespace PhoneStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return (IActionResult)View();
        }

        public IActionResult Privacy()
        {
            return (IActionResult)View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return (IActionResult)View();
        }
    }
}