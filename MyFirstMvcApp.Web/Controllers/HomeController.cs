using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.Web.Models;
using System.Diagnostics;
using System.Text;

namespace MyFirstMvcApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine("<ul>");
            stringBuilder.AppendLine("<li>");
            stringBuilder.AppendLine("<a href='http://www.gazzetta.it'>Sport</a>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("<li>");
            stringBuilder.AppendLine("<a href='http://www.github.com'>Code</a>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("<li>");
            stringBuilder.AppendLine("<a href='http://www.hln.be'>Nieuws</a>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("</ul>");
            return Content(stringBuilder.ToString(),"text/html");
        }
        public IActionResult WhatsMyName()
        {
            return Content($"Mileto Di Marco {DateTime.Now}");
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
