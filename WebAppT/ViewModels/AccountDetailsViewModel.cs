using WebAppT.Models;

namespace WebAppT.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel
    {
        ProfileImg = "images/lebron.jpg",
        FirstName = "Ömer",
        LastName = "Assadi",
        Email = "Omer@domain.com"

    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
