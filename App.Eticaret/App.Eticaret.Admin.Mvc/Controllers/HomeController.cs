using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace App.Eticaret.Admin.Mvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
