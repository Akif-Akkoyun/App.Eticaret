using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Mvc.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet("/profil/{id}/details")]
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet("/profil/{id}/my-orders")]
        public IActionResult MyOrders()
        {
            return View();
        }
        [HttpGet("/profil/{id}/my-products")]
        public IActionResult MyProducts()
        {
            return View();
        }
    }
}
