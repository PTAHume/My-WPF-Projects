using SharingData.Core;
using SharingData.Services;

namespace SharingData.ViewModel;

public class SettingsViewModel : ViewModelBase
{
    public IItemsService ItemsService { get; set; }
    public RelayCommand AddItemCommand { get; set; }

    public string? Name { get; set; }

    public SettingsViewModel(IItemsService itemsService)
    {
        ItemsService = itemsService;
        AddItemCommand = new RelayCommand(execute => { ItemsService.AddItem(Name); }, canExecute => true);
    }
}