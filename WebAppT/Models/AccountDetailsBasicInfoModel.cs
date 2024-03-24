using System.ComponentModel.DataAnnotations;

namespace WebAppT.Models;

public class AccountDetailsBasicInfoModel
{
    [DataType(DataType.ImageUrl)]
    public string? ProfileImg {  get; set; }

    [Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name", Prompt = "Enter your Last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email address", Prompt = "Enter your email", Order = 2)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [DataType(DataType.PhoneNumber)]
    [Display(Name = "PhoneNumber", Prompt = "Enter your phone", Order = 3)]
    [Required(ErrorMessage = "Phone is required")]
    public string PhoneNumber { get; set; } = null!;

    [DataType(DataType.MultilineText)]
    [Display(Name = "Bio", Prompt = "Add a short bio...", Order = 4)]
    public string? Bio { get; set; }
}
