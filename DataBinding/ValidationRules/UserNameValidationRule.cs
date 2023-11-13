using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace DataBinding.ValidationRules;

public class UserNameValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        Regex regex = new Regex(@"^[A-Za-z0-9!@#$%^&]{2,10}$");
        string? val = (string?)value;
        if (string.IsNullOrEmpty(val) || !regex.IsMatch(val))
        {
            return new ValidationResult(false, "Please enter valid email or username");
        }
        else
        {
            return ValidationResult.ValidResult;
        }
    }
}