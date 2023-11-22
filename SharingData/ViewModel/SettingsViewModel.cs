using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using SharingData.Core;
using SharingData.Services;



namespace SharingData.ViewModel;


public class SettingsViewModel : ViewModelBase
{
    public IItemsService ItemsService { get; set; }
    public RelayCommand AddItemCommand { get; set; }

    private readonly IMessenger _messenger;

    public string? Name { get; set; }

    public SettingsViewModel(IItemsService itemsService, IMessenger messenger)
    {
        _messenger = messenger;
        AddItemCommand = new RelayCommand(execute => { ItemsService.AddItem(Name ?? "Default"); }, canExecute => true);
    }

    public void SendMessage()
    {
       // _messenger.Send(new UserMessage { Content = "Hello from SenderViewModel" });
    }
}