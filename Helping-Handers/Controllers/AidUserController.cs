using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace People_Aider.Controllers
{
    public class AidUserController : Controller
    {
        private readonly ILogger<AidUserController> _logger;

        public AidUserController(ILogger<AidUserController> logger)
        {
            _logger = logger;
        }
        // GET: AidUser
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DonateIndex()
        {
            return View();
        }


        public ActionResult IncidentReport()
        {
            return View();
        }
    }
}