using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Controller
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
