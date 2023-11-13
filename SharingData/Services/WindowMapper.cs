using SharingData.View;
using SharingData.ViewModel;
using System.Windows;

namespace SharingData.Services;

public class WindowMapper
{
    private readonly Dictionary<Type, Type> _mapper = new();

    public WindowMapper()
    {
        RegisterMapping<MainViewModel, MainWindow>();
        RegisterMapping<SettingsViewModel, SettingsWindow>();
    }

    public void RegisterMapping<TViewModel, TWindow>() where TViewModel : ViewModelBase where TWindow : Window
    {
        _mapper[typeof(TViewModel)] = typeof(TWindow);
    }

    public Type GetWindowTypeForViewModel(Type viewModelType)
    {
        _mapper.TryGetValue(viewModelType, out var windowType);
        return windowType;
    }
}