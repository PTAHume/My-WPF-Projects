using DInWPF.StartUpHelpers;
using System.Windows;
using WPFLibrary;

namespace DInWPF;

public partial class MainWindow : Window
{
    private readonly IDataAccess _dataAccess;
    private readonly IAbstractFactory<ChildForm> _factory;

    public MainWindow(IDataAccess dataAccess, IAbstractFactory<ChildForm> factory)
    {
        InitializeComponent();
        _dataAccess = dataAccess;
        _factory = factory;
    }

    private void getData_Click(object sender, RoutedEventArgs e)
    {
        Data.Text = _dataAccess.GetData();
    }

    private void OpenChildForm_Click(object sender, RoutedEventArgs e)
    {
        _factory.Create().Show();
    }
}