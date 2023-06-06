using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
