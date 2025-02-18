using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Admin.Mvc.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("/product/{id}/delete")]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
