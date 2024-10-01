using Helping_Handers.Controllers;
using Helping_Handers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Helping_Handers.Controllers
{
    public class DonationController : Controller
    {
        private readonly ILogger<DonationController> _logger;

        public DonationController(ILogger<DonationController> logger)
        {
            _logger = logger;
        }
        // GET: Donation
        public IActionResult Food()
        {
            return View();
        }

        public IActionResult Clothing()
        {
            return View();
        }

        public IActionResult MedicalSupplies()
        {
            return View();
        }

    }
}