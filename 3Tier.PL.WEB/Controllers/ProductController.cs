using Microsoft.AspNetCore.Mvc;

namespace _3Tier.PL.WEB.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
