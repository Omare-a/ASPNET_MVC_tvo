using System.ComponentModel.DataAnnotations;

namespace WebAppT.Helpers;

public class CheckBoxRequired: ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;

}
