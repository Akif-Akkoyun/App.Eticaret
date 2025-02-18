using Microsoft.AspNetCore.Mvc;
namespace App.Eticaret.Mvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet("/about-us")]
    public IActionResult AboutUs()
    {
        return View();
    }
    [HttpGet("/contact")]
    public IActionResult Contact()
    {
        return View();
    }
    [HttpGet("/product/{categoryName}/list")]
    public IActionResult Listing()
    {
        return View();
    }
    [HttpGet("/product/{id:int}/details")]
    public IActionResult ProductDetail()
    {
        return View();
    }
}
