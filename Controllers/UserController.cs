using Microsoft.AspNetCore.Mvc;

namespace chat.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
