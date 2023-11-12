using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using DInWPF.StartUpHelpers;
using DInWPF.ViewModels;
using System.Windows;
using WPFLibrary;
namespace DInWPF;

public partial class MainWindow :  Window
{

    public MainWindow(MainViewModel viewModel)//, IAbstractFactory<ChildForm> factory)
    {
        InitializeComponent();
        this.DataContext = viewModel;//new MainViewModel(factory, dataAccess);
    }
}