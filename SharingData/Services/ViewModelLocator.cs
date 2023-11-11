using Microsoft.Extensions.DependencyInjection;
using SharingData.ViewModel;

namespace SharingData.Services;

public class ViewModelLocator
{
    private readonly IServiceProvider _serviceProvider;

    public ViewModelLocator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public MainViewModel MainViewModel => _serviceProvider.GetRequiredService<MainViewModel>();
    public SettingsViewModel SettingsViewModel => _serviceProvider.GetRequiredService<SettingsViewModel>();
}