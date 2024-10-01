using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Helping_Handers.Controllers
{
    public class AidVolunteerController : Controller
    {
        private readonly ILogger<AidVolunteerController> _logger;

        public AidVolunteerController(ILogger<AidVolunteerController> logger)
        {
            _logger = logger;
        }
        // GET: AidVolunteer
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IncidentAssignment()
        {
            return View();
        }
    }
}