using Helping_Handers.Controllers;
using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace People_Aider.Controllers
{
    public class DonationController : Controller
    {
        private readonly ILogger<DonationController> _logger;

        public DonationController(ILogger<DonationController> logger)
        {
            _logger = logger;
        }
        // GET: Donation
        public ActionResult Food()
        {
            return View();
        }

        public ActionResult Clothing()
        {
            return View();
        }

        public ActionResult MedicalSupplies()
        {
            return View();
        }

    }
}