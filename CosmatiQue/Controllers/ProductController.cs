using Microsoft.AspNetCore.Mvc;

namespace CosmatiQue.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

    }
}
