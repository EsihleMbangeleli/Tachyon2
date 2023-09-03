using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tachyon.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< Updated upstream
=======
		public IActionResult Index2()
		{
			return View();
		}
>>>>>>> Stashed changes
		public IActionResult Index3()
		{
			return View();
		}
	}
}
