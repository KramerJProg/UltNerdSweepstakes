using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltNerdSweepstakes.Controllers
{
    public class ContestantController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
