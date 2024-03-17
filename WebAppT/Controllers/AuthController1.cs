using Microsoft.AspNetCore.Mvc;

namespace WebAppT.Controllers;

public class AuthController1 : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
