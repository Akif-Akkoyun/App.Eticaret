using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Mvc.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("/forgot-password")]
        public IActionResult ForgatPassword()
        {
            return View();
        }
        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
