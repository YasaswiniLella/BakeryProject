﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class BakeryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult newaction()
        {
            return View();
        }
    }
}
