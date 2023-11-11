using CommunityToolkitExperiments.ViewModels;
using System.Windows;

namespace CommunityToolkitExperiments;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainViewModel();
    }
}