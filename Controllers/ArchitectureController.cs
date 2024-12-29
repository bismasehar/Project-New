using Microsoft.AspNetCore.Mvc;

namespace Project_New.Controllers
{
    public class ArchitectureController : Controller
    {
        public IActionResult Index()
        {
            return View();
     
        }
        public IActionResult Hospitality()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult Commercial()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.Message = "Please fill out the contact form.";
            
            return View();
        }

        // POST: /Architecture/Contact
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            ViewBag.Message = "Help";
            ViewData["Message"] = "";
            TempData["Message"] = "";
            if (name == "Bisma" && email == "bismasehar203@gmail.com")
            {
                ViewBag.Message = "You have successfully logged into the system!";
            }
            else
            {
                ViewBag.Message = "Your email or username may not be correct!";
            }

            // Use only one method for passing messages to the view
            ViewData["Response"] = "This is a response message from ViewData.";
            TempData["Alert"] = "Temporary alert for testing TempData.";

            return View();
       
}
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult Public()
        {
            return View();
        }
        public IActionResult Residential()
        {
            return View();
        }
    }
}
   
