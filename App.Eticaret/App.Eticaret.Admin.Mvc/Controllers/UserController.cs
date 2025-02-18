using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Admin.Mvc.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("/admin/user-list")]
        public IActionResult List()
        {
            return View();
        }
        [HttpGet("/admin/user-approve")]
        public IActionResult Approve()
        {
            return View();
        }
    }
}
