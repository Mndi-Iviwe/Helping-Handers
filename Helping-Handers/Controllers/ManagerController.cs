using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Helping_Handers.Data;

namespace Helping_Handers.Controllers
{
    [Route("[controller]/[action]")]
    public class ManagerController : Controller
    {

        private readonly ILogger<ManagerController> _logger;
        private readonly Helping_HandDbContext _context;


        public ManagerController(Helping_HandDbContext context, ILogger<ManagerController> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<IActionResult> ManagementIndex()
        {
            //Submitted reports that have not been approved will only be listed in the index
            var report = await _context.Reports.ToListAsync();
            return View(report);
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
