﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltNerdSweepstakes.Models;

namespace UltNerdSweepstakes.Controllers
{
    public class ContestantController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            // Contestant object
            Contestant cont = new Contestant();
            cont.FullName = form["full-name"];
            cont.Email = form["email"];
            cont.Phone = form["phone"];

            // This is where we would add to the database!

            ViewData["Added"] = cont.FullName + ", you are entered! Good Luck!";

            return View();
        }

        [HttpGet]
        public IActionResult UsingModelBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UsingModelBinding(Contestant cont)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = $"{cont.FullName}, congrats! You've have entered the contest!";

                // This is where we add to the database!
            }
            return View();
        }
    }
}
