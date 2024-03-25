using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Views;

namespace WebAppT.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomIndexViewModel();

        ViewData["Title"] = viewModel.Title;

        return View(viewModel);
    }
}
