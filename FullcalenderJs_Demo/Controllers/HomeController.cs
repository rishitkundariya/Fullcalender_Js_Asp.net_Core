using FullcalenderJs_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FullcalenderJs_Demo.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MultiEvent()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult getDatesOfAllDayEvent()
        {
            List<CalenderViewModel> lstCalenderViewModels = new List<CalenderViewModel>();
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Red", DateTime = DateTime.Now.ToString("dd/MM/yyyy"), Id = 1 , title ="First Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Green", DateTime = DateTime.Today.AddDays(3).ToString("dd/MM/yyyy"), Id = 2 , title ="Second Event"});
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Blue", DateTime = DateTime.Today.AddDays(5).ToString("dd/MM/yyyy"), Id = 3 , title = "Third Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Yellow", DateTime = DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy"), Id = 4, title = "Fourth Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Orange", DateTime = DateTime.Today.AddDays(-3).ToString("dd/MM/yyyy"), Id = 5,title  =  "Fifth Event" });
            return new JsonResult(lstCalenderViewModels);
        }
        public IActionResult getDatesOfAllMultiEvent()
        {
            List<CalenderViewModel> lstCalenderViewModels = new List<CalenderViewModel>();
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Red", DateTime = DateTime.UtcNow.AddDays(1).ToString(), Id = 1, title = "First Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Green", DateTime = DateTime.UtcNow.AddDays(1).AddHours(2).ToString(), Id = 2, title = "Second Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Blue", DateTime = DateTime.UtcNow.AddDays(1).AddHours(5).ToString(), Id = 3, title = "Third Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Yellow", DateTime = DateTime.UtcNow.AddDays(3).AddHours(1).ToString(), Id = 4, title = "Fourth Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "Orange", DateTime = DateTime.UtcNow.AddDays(3).AddHours(4).ToString(), Id = 5, title = "Fifth Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "black", DateTime = DateTime.UtcNow.AddDays(-1).AddHours(1).ToString(), Id = 6, title = "Six Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "brown", DateTime = DateTime.UtcNow.AddDays(-4).AddHours(4).ToString(), Id = 7, title = "Seven Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "pink", DateTime = DateTime.UtcNow.AddDays(-6).AddHours(4).ToString(), Id = 8, title = "Eight Event" });
            lstCalenderViewModels.Add(new CalenderViewModel { color = "lightgreen", DateTime = DateTime.UtcNow.AddDays(-6).AddHours(5).ToString(), Id = 9, title = "Nine Event" });
            return new JsonResult(lstCalenderViewModels);
        }
    }

    class CalenderViewModel
    {
        public string color { get; set; }
        public string DateTime { get; set; }
        public int Id { get; set; }
        public string title { get; set; }
    }
}