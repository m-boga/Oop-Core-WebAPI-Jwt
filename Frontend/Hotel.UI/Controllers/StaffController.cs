using Microsoft.AspNetCore.Mvc;

namespace Hotel.UI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
