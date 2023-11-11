using DataBinding.ValidationRules;
using DataBinding.ViewModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace DataBinding.Views
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private AddUserViewModel ViewModel { get; }
        public AddUser()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new AddUserViewModel();
        }

     ///   private void UserName_Error(object sender, ValidationErrorEventArgs e)
       // {
           // AddUserBtn.IsEnabled  =   e.Action != ValidationErrorEventAction.Added ;
           // Debug.Write(UserName.Text);
     
       // }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           // TextBox ?foo = (TextBox)sender;
           // AddUserBtn.IsEnabled = !(string.IsNullOrEmpty(foo?.Text));
        }
    }
}
