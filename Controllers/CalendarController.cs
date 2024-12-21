using Microsoft.AspNetCore.Mvc;

namespace eMungesat.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
