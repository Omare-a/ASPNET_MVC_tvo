﻿using Microsoft.AspNetCore.Mvc;
using WebAppT.ViewModels;

namespace WebAppT.Controllers;

public class AuthController : Controller
{
	[Route("/signup")]
    [HttpGet]
	public IActionResult SignUp()
	{
		var viewModel = new SignUpViewModel();
		return View(viewModel);
	}

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        if(!ModelState.IsValid)
            return View(viewModel);

        return RedirectToAction("SignIn", "Auth");
    }

    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            viewModel.ErrorMassage = "Incorrect email or passwors";
            return View(viewModel);
        }
            

        return RedirectToAction("Account", "Index");
    }

}
