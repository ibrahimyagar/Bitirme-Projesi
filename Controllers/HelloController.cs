using Microsoft.AspNetCore.Mvc;

namespace EduHub.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return Redirect("Home/Index");
            }

            return View();

        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}
