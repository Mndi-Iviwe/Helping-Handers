using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Helping_Handers.Controllers
{
    [Route("[controller]/[action]")]
    public class AidVolunteerController : Controller
    {
        private readonly ILogger<AidVolunteerController> _logger;

        public AidVolunteerController(ILogger<AidVolunteerController> logger)
        {
            _logger = logger;
        }

        // GET: AidVolunteer
        public IActionResult VolunteerIndex()
        {
            //Volunteer landing page
            //If a Volunteers project has been approved by the manager they must await a confirmation
            //If a volunteer is assigned to a project, it must be displayed here
            return View();
        }

        public IActionResult IncidentApplication()
        {
            //Volunteer must be able assign themselves to an approved aid project
            return View();
        }


    }
}