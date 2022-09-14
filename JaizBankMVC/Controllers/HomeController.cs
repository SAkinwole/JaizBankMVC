using JaizBankMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JaizBankMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            Transaction transaction = new Transaction()
            {
                TransactionID = 1,
                MerchantName = "Lizpee Global Resources",
                Location = "",
                TerminalID = 1,
                STAN = 003862,
                DateTime = DateTime.Now,
                Amount = "NGN0.01",
                DebitCardNo = "539941*******3399",
                ExpiryDate = "11/24",
                AuthorizationCode = 00000,
                Offline = "CVM",
                ResponseCode = 91,
                AID = "A0000000000000041010",
                RRN = "000210002450",
                Accelerex = "2.00-090921-LINT",
                PTAD = "Global Accelerex"
            };
        }

        public IActionResult Index()
        {
            var jaizBankView = new Transaction()
            {
                TransactionID = 1,
                MerchantName = "LIZPEE GLOBAL RESOURCES",
                Location = "NO, 174, NTA/MBOURA RD, PORTHARCOURT",
                TerminalID = 23011845,
                STAN = 003862,
                DateTime = DateTime.Now,
                Amount = "NGN0.01",
                DebitCardNo = "539941*******3399",
                ExpiryDate = "11/24",
                AuthorizationCode = 000000,
                Offline = "CVM",
                ResponseCode = 91,
                AID = "A0000000000000041010",
                RRN = "000210002450",
                Accelerex = "2.00-090921-LINT",
                PTAD = "Global Accelerex"
            };

            return View(jaizBankView); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}