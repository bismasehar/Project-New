using Microsoft.AspNetCore.Mvc;
using Project_New.Data;
using Project_New.Models;

namespace Project_New.Controllers
{
    public class ArchitectureController : Controller
    {
        private readonly ILogger<ArchitectureController> _logger;
        private readonly DataDbContext _login;

        public ArchitectureController(ILogger<ArchitectureController> logger, DataDbContext login)
        {
            _logger = logger;
            _login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hospitality()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Commercial()
        {
            return View();
        }

        [HttpGet]
        public IActionResult contact()
        {
            ViewBag.Message = "Please fill out the contact form.";
            return View();
        }
        [HttpPost]
        public IActionResult contact(Login data)
        {
            try
            {
                if (data != null)
                {
                    // Add the new record to the Login table
                    _login.Login.Add(data);
                    _login.SaveChanges();

                    ViewBag.Message = "Record added successfully.";
                }
                else
                {
                    ViewBag.Message = "Invalid input. Please fill in all required fields.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding the contact record.");
                ViewBag.Message = "Something went wrong. Please check the database.";
            }

            // Load all login records for display
            ViewBag.Logins = _login.Login.OrderBy(x => x.name).ToList();
            return View("contact");
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
