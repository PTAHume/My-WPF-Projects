using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using Validation.Commands;

namespace Validation.ViewModels;

public class MainViewModel : INotifyDataErrorInfo
{    
    private string _name;
    private string _email;
    private string _password;
    private Dictionary<string, List<string>> Erros = new Dictionary<string, List<string>>();

    public bool HasErrors => Erros.Count > 0;
    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
    public ActionCommand  SubmitCommand { get; set; }
    public MainViewModel()
    {
        SubmitCommand = new ActionCommand(Submit, CanSubmit);
    }

    private bool CanSubmit(object obj)
    {
        return Validator.TryValidateObject(this, new ValidationContext(this), null);
    }

    private void Submit(object obj)
    {
        MessageBox.Show("Submited");
    }

    public IEnumerable GetErrors(string? propertyName)
    {
        if (Erros.ContainsKey(propertyName))
        {
            return Erros[propertyName];
        }
        else
        {
            return Enumerable.Empty<string>();
        }
    }

    public void Validate(string propertyName, object propertyValue)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(propertyValue,
                new ValidationContext(this) { MemberName = propertyName }, results);

        if (results.Any())
        {
            Erros.Add(propertyName, results.Select(r => r.ErrorMessage).ToList());
        }
        else
        {
            Erros.Remove(propertyName);
        }
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        SubmitCommand.RaiseCanExecuteChanged();
    }



    [Required(ErrorMessage = "Name is required")]
    public string Name
    {
        get { return _name; }
        set
        {
            _name = value;
            Validate(nameof(Name), value);
        }
    }

    [Required(ErrorMessage = "Email is required")]
    public string Email
    {
        get { return _email; }
        set
        {
            _email = value;
            Validate(nameof(Email), value);
        }
    }

    [Required(ErrorMessage = "Password is required")]
    public string Password
    {
        get { return _password; }
        set
        {
            _password = value;
            Validate(nameof(Password), value);
        }
    }
}