using Microsoft.AspNetCore.Mvc;
using MyDreamStartUp.Models;
using MySqlConnector;
using System.Diagnostics;
using System;
using System.Linq;
using System.Web;
using MyDreamStartUp.Db;
using Microsoft.Data.SqlClient;

namespace MyDreamStartUp.Controllers
{
    public class q1Controller : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public q1Controller(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult profile()
        {
            return View();
        }
        public IActionResult company()
        {
            return View();
        }
        public IActionResult product()
        {
            return View();
        }
        public IActionResult collaboration()
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
