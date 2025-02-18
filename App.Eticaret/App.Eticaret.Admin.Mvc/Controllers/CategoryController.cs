using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Admin.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet("category/")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet("category/{id}/edit")]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet("category/{id}/delete")]
        public IActionResult Delete()
        {
            return View();
        }
        
    }
}
