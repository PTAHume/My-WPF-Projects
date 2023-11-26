using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataGrid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataGrid.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public List<string> UserTypes { get; } = new List<string>{
            "Admin",
            "Standard"
    };

    public ObservableCollection<User> Users { get; } = new();

    public MainWindowViewModel()
    {
        var random = new Random();
        Users.Add(new User { Name = "Joe", Age = 20 });
        for (int i = 0; i < 10; i++)
        {
            Users.Add(new User { Name = $"User {i}", Age = random.Next(1, 100) });
        }
    }

    [RelayCommand]
    public void NewUser()
    {
        Users.Add(new User
        {
            Name = $"User {Users.Count}",
            Age = new Random().Next(1, 100)
        });
    }

    [RelayCommand]
    private void DeleteUser(User user)
    {
        Users.Remove(user);
    }
}