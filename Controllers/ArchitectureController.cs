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

            [HttpPost]
            public IActionResult Contact(string name, string email, string message)
            {
                if (name == "Bisma" && email == "bismasehar203@gmail.com")
                {
                    ViewData["Response"] = "Your Message is Send Successfully!";
                    //TempData["FormSubmitted"] = true; // To hide the form after submission
                }
                else
                {
                    TempData["Alert"] = "Your email or username may not be correct!";
                    ViewData["Response"] = "Please try again.";
                }

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
   
