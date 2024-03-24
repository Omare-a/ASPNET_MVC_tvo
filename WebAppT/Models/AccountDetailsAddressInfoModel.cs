using System.ComponentModel.DataAnnotations;

namespace WebAppT.Models;

public class AccountDetailsAddressInfoModel
{

    [Display(Name = "Address line 1", Prompt = "Enter your address line", Order = 0)]
    [Required(ErrorMessage = "address is required")]
    public string AddressLineOne { get; set; } = null!;

    [Display(Name = "Address line 2", Prompt = "Enter your second address line", Order = 1)]
    public string? AddressLineTwo { get; set; }

    [DataType(DataType.PostalCode)]
    [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 2)]
    [Required(ErrorMessage = "Postal code is required")]
    [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}
