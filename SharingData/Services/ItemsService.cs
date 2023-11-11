using System.Collections.ObjectModel;

namespace SharingData.Services;

public interface IItemsService
{
    public ObservableCollection<string> Items { get; set; }

    void AddItem(string item);
}

public class ItemsService : IItemsService
{
    public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

    public void AddItem(string item)
    {
        Items.Add(item);
    }
}