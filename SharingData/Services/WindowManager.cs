using SharingData.ViewModel;
using System.Windows;

namespace SharingData.Services;

public class WindowManager : IWindowManager
{
    private readonly WindowMapper _windowMapper;

    public WindowManager(WindowMapper windowMapper)
    {
        _windowMapper = windowMapper;
    }

    public void ShowWindow(ViewModelBase viewModel)
    {
        var windowType = _windowMapper.GetWindowTypeForViewModel(viewModel.GetType());
        if (windowType != null)
        {
            var window = Activator.CreateInstance(windowType) as Window;
            window.DataContext = viewModel;
            window.Show();
            window.Closed += (senderObject, args) => CloseWindow();
        }
    }

    public void CloseWindow()
    {
        MessageBox.Show("Closed Window");
    }
}

public interface IWindowManager
{
    void ShowWindow(ViewModelBase viewModel);

    void CloseWindow();
}