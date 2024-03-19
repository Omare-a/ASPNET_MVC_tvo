using Microsoft.AspNetCore.Mvc;

namespace WebAppT.Controllers;

public class AuthController : Controller
{
	[Route("/signup")]
	public IActionResult SignUp()
	{
		return View();
	}
}
