﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StraxService.Areas.admin.Controllers
{
    [Area("admin")]
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}