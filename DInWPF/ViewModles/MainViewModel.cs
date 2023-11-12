
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DInWPF.StartUpHelpers;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WPFLibrary;


namespace DInWPF.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IDataAccess _dataAccess;
    private readonly IAbstractFactory<ChildForm> _factory;


    [ObservableProperty]
    private string? _dataField;

    public MainViewModel(IAbstractFactory<ChildForm> factory, IDataAccess dataAccess)
    {
        _factory = factory;
        _dataAccess = dataAccess;
    }

    [RelayCommand]
    private void GetData()
    {
        DataField = _dataAccess.GetData();
    }

    [RelayCommand]
    public void OpenChildForm()
    {
        _factory.Create().Show();
    }
}
