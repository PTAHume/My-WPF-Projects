﻿using SharingData.Core;
using SharingData.Services;

namespace SharingData.ViewModel;

public class MainViewModel : ViewModelBase
{
    private readonly IWindowManager _windowManager;
    private readonly ViewModelLocator _viewModelLocator;

    public IItemsService ItemsService { get; set; }
    public RelayCommand OpenSettingsWindowCommand { get; set; }

    public MainViewModel(IItemsService itemsService, IWindowManager windowManager, ViewModelLocator viewModelLocator) //: base(messenger)
    {
        _viewModelLocator = viewModelLocator;
        _windowManager = windowManager;
        ItemsService = itemsService;
        //IMessenger messenger = Messenger;
        //messenger.Register<UserLoggedIn>(this);

        //somewhere else
       // messenger.Send(new UserLoggedIn("foo"));
        OpenSettingsWindowCommand = new RelayCommand(execute => { _windowManager.ShowWindow(_viewModelLocator.SettingsViewModel); }, canExecute => true);
    }
}