using System.Diagnostics;
using DotnetCore_CrudProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore_CrudProject.Controllers
{
    public class HomeController : Controller
    {


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ApplicationDBContext DbContext;
        public HomeController(ApplicationDBContext DbContext) 
        {
            this.DbContext= DbContext;
        }

        public IActionResult Index()
        {
            var studentData = DbContext.Students.ToList();
            return View(studentData);
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
