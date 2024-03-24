using Microsoft.AspNetCore.Mvc;
using WebAppT.ViewModels;

namespace WebAppT.Controllers;

public class AccountController : Controller
{
    [Route("/profile")]
    public IActionResult Details(AccountDetailsViewModel viewModel)
    {
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    {
        return RedirectToAction(nameof(Details), viewModel);
    }

    [HttpPost]
    public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
    {
        return RedirectToAction(nameof(Details), viewModel);
    }

}
