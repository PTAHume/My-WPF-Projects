using DataBinding.Models;
using DataBinding.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DataBinding.Views;

public partial class Main : Window
{
    public Main()
    {
        InitializeComponent();
        MainViewModel mainViewModel = new();
        this.DataContext = mainViewModel;
    }

    private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        UserList.Items.Filter = FilerMethod;
    }

    private bool FilerMethod(object obj)
    {
        var user = (User)obj;
        if (user?.UserName != null)
        {
            return user.UserName.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }
}