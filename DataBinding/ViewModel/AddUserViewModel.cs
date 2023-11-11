using DataBinding.Commands;
using DataBinding.Models;
using System;
using System.Windows.Input;

namespace DataBinding.ViewModel
{
    public class AddUserViewModel
    {
        public ICommand AddUserCommand { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
            ClickCommand = new RelayCommand(Click, delegate (object obj) { return true; });
        }

        private bool CanAddUser(object obj) => true;

        public ICommand ClickCommand { get; set; }
        public void Click(object obj)
        {
            Console.Write("");
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(new User { UserName = UserName, Email = Email });
        }
    }
}
