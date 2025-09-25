using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace H2.Actionresults.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<ul>");
            stringBuilder.AppendLine("<li><a href='https://www.gazzetta.it'>Gazzetta</a></li>");
            stringBuilder.AppendLine("<li><a href='https://www.github.com'>Github</a></li>");
            stringBuilder.AppendLine("<li><a href='https://www.hln.be'>Hln</a></li>");
            stringBuilder.AppendLine("<li><a href='/home/whatsmyname'>WhatsMyName</a></li>");
            stringBuilder.AppendLine("</ul>");
            return Content(stringBuilder.ToString(),"text/html");
        }
        public IActionResult WhatsMyName() 
        {
            //return name and date of today
            var content = $"{Environment.UserName}:{DateTime.Today.ToShortDateString()}";
            return Content(content, "text/plain");
        }
    }
}
