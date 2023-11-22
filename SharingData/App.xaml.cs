using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using SharingData.Core;
using SharingData.Services;
using SharingData.ViewModel;
using System.Windows;

namespace SharingData;

public partial class App : Application
{
    public readonly IServiceCollection services = new ServiceCollection();
    private readonly IServiceProvider _serviceProvider;

    public App()
    {
        services.AddSingleton<MainViewModel>();
        services.AddTransient<SettingsViewModel>();

        services.AddSingleton<ViewModelLocator>();
        services.AddSingleton<WindowMapper>();
        services.AddSingleton<IWindowManager, WindowManager>();
        services.AddSingleton<IItemsService, ItemsService>();
        services.AddSingleton<IMessenger, Messenger>();
        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        //Messenger = WeakReferenceMessenger.Default;

        var windowManger = _serviceProvider.GetRequiredService<IWindowManager>();
        windowManger.ShowWindow(_serviceProvider.GetRequiredService<MainViewModel>());
        base.OnStartup(e);
    }
}