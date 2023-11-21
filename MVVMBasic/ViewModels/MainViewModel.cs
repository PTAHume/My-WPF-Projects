using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace CommunityToolkitExperiments.ViewModels;

public record class UserLoggedIn(string UserName);

[ObservableObject]
[ObservableRecipient]
public partial class MainViewModel : IRecipient<UserLoggedIn>
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ClickCommand))]
    public string? _firstName = "Foo";

    [ObservableProperty]
    public bool _loading;

    [ObservableProperty]
    public int _loadingValue;

     partial void OnFirstNameChanging(string? value)
    { }

    public MainViewModel()
    // : base(messenger)
    {
        Messenger = WeakReferenceMessenger.Default;
        // Messenger = messenger;
        Foo();
    }

    private void Foo()
    {
        //WeakReferenceMessenger.Default
        IMessenger messenger = Messenger;
        messenger.Register<UserLoggedIn>(this);

        //somewhere else
        messenger.Send(new UserLoggedIn("foo"));
    }

    //private bool CanClick() => FirstName == "Foo";

    [RelayCommand(IncludeCancelCommand = true)]//CanExecute = nameof(CanClick))
    private async Task OnClick(CancellationToken token)
    {
        try
        {
            Loading = true;

            // ExecuteEverySecond();
            await Task.Delay(3_000, token);
            FirstName += "bar";
        }
        catch (OperationCanceledException ex)
        {
            FirstName += " x ";
        }
        Loading = false;
    }

    public void Receive(UserLoggedIn message)
    {
    }
}

//vm = serve data eg server up color
//v = cam massagre data e.ge convert data