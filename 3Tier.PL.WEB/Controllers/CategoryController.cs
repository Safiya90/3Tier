using Microsoft.AspNetCore.Mvc;

namespace _3Tier.PL.WEB.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
