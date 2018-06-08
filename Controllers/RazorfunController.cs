using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace razorfun.Controllers
{
    public class RazorfunController:Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}