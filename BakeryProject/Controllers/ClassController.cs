﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void GetName()
        {

        }
    }
}
