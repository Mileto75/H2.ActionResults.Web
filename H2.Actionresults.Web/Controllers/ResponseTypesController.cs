using Microsoft.AspNetCore.Mvc;

namespace H2.Actionresults.Web.Controllers
{
    public class ResponseTypesController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ResponseTypesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Fail()
        {
            return NotFound();
        }
        public IActionResult Forward()
        {
            return Redirect("/Home/WhatsMyName");
            //return RedirectToAction("WhatsMyName","Home");
        }
        public IActionResult Download()
        {
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "files", "h02-1.controllers.pdf");
            var filestream = new FileStream(path, FileMode.Open);
            return File(filestream, "application/pdf","oefening1.pdf");
        }
    }
}
