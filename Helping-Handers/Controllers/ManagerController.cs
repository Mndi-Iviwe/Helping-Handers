using Microsoft.AspNetCore.Mvc;

namespace Helping_Handers.Controllers
{
    [Route("[controller]/[action]")]
    public class ManagerController : Controller
    {

        private readonly ILogger<ManagerController> _logger;

        public ManagerController(ILogger<ManagerController> logger)
        {
            _logger = logger;
        }

        public IActionResult ManagementIndex()
        {
            //Submitted reports that have not been approved will only be listed in the index
            return View();
        }

        public IActionResult IncidentAssignHub()
        {
            //This is where the manager should be able to update the status of submitted results
            return View();
        }

        public IActionResult ResourceTracking()
        {
            //Prepare donated resources in this method
            return View();
        }
    }
}
