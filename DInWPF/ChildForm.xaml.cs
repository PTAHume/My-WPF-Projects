using CommunityToolkit.Mvvm.Messaging;
using DInWPF.Model;
using WPFLibrary;

namespace DInWPF;

//[ObservableRecipient]
public partial class ChildForm : IRecipient<UserLoggedIn>
{
    private readonly IDataAccess _dataAccess;

    public ChildForm(IDataAccess dataAccess)
    {
        InitializeComponent();
        _dataAccess = dataAccess;
        //  IMessenger Messenger = messenger;
        // messenger.Register<UserLoggedIn>(this);

        //_dataAccess.GetData();
    }

    public void Receive(UserLoggedIn message)
    {
    }
}