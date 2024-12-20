using Microsoft.AspNetCore.Mvc;

namespace eMungesat.Controllers
{
    public class SchedulerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
