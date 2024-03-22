using WebAppT.Models;

namespace WebAppT.ViewModels;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign In";
    public SignInModel Form { get; set; } = new SignInModel();
    public string? ErrorMassage { get; set; }

}
