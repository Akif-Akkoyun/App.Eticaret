using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Admin.Mvc.Controllers
{
    public class CommentController : Controller
    {
        [HttpGet("/comment/list")]
        public IActionResult List()
        {
            return View();
        }
        [HttpGet("/comment/approve")]
        public IActionResult Approve()
        {
            return View();
        }
    }
}
