using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    internal class StudentClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
    record StudentRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StudentClass s1 = new() { Id = 1, FirstName = "Jon", LastName = "Doe" };
            ViewData["d1"] = s1.GetHashCode();
            ViewData["d2"] = s1.GetHashCode();
            ViewData["d3"] = s1.GetHashCode();

            StudentClass s2 = new() { Id = 2, FirstName = "Bob", LastName = "Dilon" };
            ViewData["d4"] = s2.GetHashCode();
            ViewData["d5"] = s2.GetHashCode();
            ViewData["d6"] = s2.GetHashCode();

            StudentRecord s3 = new() { Id = 1, FirstName = "Rahul", LastName = "Roy" };
            ViewData["d7"] = s3.GetHashCode();
            ViewData["d8"] = s3.GetHashCode();
            ViewData["d9"] = s3.GetHashCode();

            StudentRecord s4 = new() { Id = 2, FirstName = "Sachin", LastName = "Bose" };
            ViewData["d10"] = s4.GetHashCode();
            ViewData["d11"] = s4.GetHashCode();
            ViewData["d12"] = s4.GetHashCode();

            return View();
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