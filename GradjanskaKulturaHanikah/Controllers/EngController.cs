using GradjanskaKulturaHanikah.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GradjanskaKulturaHanikah.Controllers
{
    public class EngController : Controller
    {
        private readonly ILogger<EngController> _logger;

        public EngController(ILogger<EngController> logger)
        {
            _logger = logger;
        }

        public IActionResult EngIndex()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
