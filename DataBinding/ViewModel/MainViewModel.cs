using DataBinding.Commands;
using DataBinding.Models;
using DataBinding.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DataBinding.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users= UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj) => true;
        
        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;
            AddUser addUserWin = new();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }
    }
}
