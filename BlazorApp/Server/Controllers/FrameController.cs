﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    public class FrameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
