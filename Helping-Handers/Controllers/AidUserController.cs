using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Helping_Handers.Controllers
{
    [Route("[controller]/[action]")]
    public class AidUserController : Controller
    {
        private readonly ILogger<AidUserController> _logger;

        public AidUserController(ILogger<AidUserController> logger)
        {
            _logger = logger;
        }
        // GET: AidUser


        public IActionResult IncidentReport()
        {
            //Users must only be able to submit/delete a report
            return View();
        }
    }
}