using System.ComponentModel.DataAnnotations;
using WebAppT.Helpers;

namespace WebAppT.Models;

public class SignUpModel
{
	[Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
	[Required(ErrorMessage = "First name is required")]
	public string FirstName { get; set; } = null!;

	[Display(Name = "Last Name", Prompt = "Enter your Last name", Order = 1)]
	[Required(ErrorMessage = "Last name is required")]
	public string LastName { get; set; } = null!;

	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email", Prompt = "Enter your email", Order = 2)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
	public string Email { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Password", Prompt = "Enter your Password", Order = 3)]
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Invalid password, must be a strong password")]
	public string Password { get; set; } = null!;

	[DataType(DataType.Password)]
	[Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
	public string ConfirmPassword { get; set; } = null!;

	[Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
	[CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions.")]
	public bool TermsAndConditions { get; set; } = false;
}


