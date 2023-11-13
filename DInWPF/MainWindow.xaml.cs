using DInWPF.ViewModels;
using System.Windows;

namespace DInWPF;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)//, IAbstractFactory<ChildForm> factory)
    {
        InitializeComponent();
        this.DataContext = viewModel;//new MainViewModel(factory, dataAccess);
    }
}