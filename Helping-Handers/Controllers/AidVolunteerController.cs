using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace People_Aider.Controllers
{
    public class AidVolunteerController : Controller
    {
        private readonly ILogger<AidVolunteerController> _logger;

        public AidVolunteerController(ILogger<AidVolunteerController> logger)
        {
            _logger = logger;
        }
        // GET: AidVolunteer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IncidentAssignment()
        {
            return View();
        }
    }
}