using Form_Request.Models;
using MaximaMachineriesInc.DAL;
using MaximaMachineriesInc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Form_Request.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
		public IActionResult Home()
        {
       
            return View();
        }


<<<<<<< Updated upstream
       
=======
        public IActionResult RFS()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

>>>>>>> Stashed changes
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }   
    }
}

