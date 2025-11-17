using Microsoft.AspNetCore.Mvc;

namespace ShopPC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
