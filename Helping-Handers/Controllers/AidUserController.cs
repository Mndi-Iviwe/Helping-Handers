using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Helping_Handers.Controllers
{
    public class AidUserController : Controller
    {
        private readonly ILogger<AidUserController> _logger;

        public AidUserController(ILogger<AidUserController> logger)
        {
            _logger = logger;
        }
        // GET: AidUser

        public IActionResult DonateIndex()
        {
            return View();
        }


        public IActionResult IncidentReport()
        {
            return View();
        }
    }
}