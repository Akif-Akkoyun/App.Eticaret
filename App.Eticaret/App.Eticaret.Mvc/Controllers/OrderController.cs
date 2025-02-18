using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Mvc.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/order/{id}/edit")]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet("/order/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet("/order/{id}/details")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
