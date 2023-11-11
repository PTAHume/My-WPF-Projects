using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using System.Windows;
using System.Windows.Controls;
using WPFLibrary;

namespace DInWPF;

public partial class ChildForm 
{
    private readonly IDataAccess _dataAccess;

    public ChildForm(IDataAccess dataAccess)
         
    {
        InitializeComponent();
        _dataAccess = dataAccess;
        DataAccessInfo.Text = dataAccess.GetData();
    }
}