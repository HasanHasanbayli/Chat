﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Controllers
{
    [Authorize]
    public class CallsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
