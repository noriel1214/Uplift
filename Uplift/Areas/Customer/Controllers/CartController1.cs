using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uplift.Areas.Customer.Controllers
{
    public class CartController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
