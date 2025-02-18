using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Mvc.Controllers
{
    public class CartController : Controller
    {
        [HttpGet("/cart/add-product")]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpGet("/cart/{id}/edit")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
