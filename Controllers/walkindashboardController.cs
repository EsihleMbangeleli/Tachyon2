using Microsoft.AspNetCore.Mvc;

namespace Tachyon.Controllers
{
    public class walkindashboardController : Controller
    {
        public IActionResult walkin()
        {
            return View();
        }
    }
}
