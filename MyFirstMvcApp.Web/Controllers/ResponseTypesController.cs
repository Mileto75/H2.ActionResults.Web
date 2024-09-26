using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvcApp.Web.Controllers
{
    public class ResponseTypesController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ResponseTypesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return Content("Index");
        }

        public IActionResult Fail()
        {
            return NotFound();
        }
        public IActionResult Forward() 
        {
            //return Redirect("/home/whatsmyname");
            return RedirectToAction("Whatsmyname","Home");
        }
        public IActionResult Download()
        {
            //return File("/docs/controllers.pdf", "application/pdf");

            var pathToFile = Path.Combine(_webHostEnvironment.WebRootPath, "docs", "controllers.pdf");
            var fileStream = new FileStream(pathToFile, FileMode.Open);
            return File(fileStream, "application/pdf");
        }
    }
}
