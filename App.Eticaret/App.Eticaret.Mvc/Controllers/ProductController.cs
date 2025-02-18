using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Mvc.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("/product/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet("/product/{id:int}/delete")]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpGet("/product/{id:int}/edit")]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet("/product/{id:int}/comment")]
        public IActionResult Comment(int id)
        {
            return View();
        }
    }
}
