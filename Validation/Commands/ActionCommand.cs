
using System.Windows.Input;

namespace Validation.Commands;

public class ActionCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Predicate<object> _canexecute;

    public event EventHandler? CanExecuteChanged;

    public ActionCommand(Action<object> execute, Predicate<object> canexecute)
    {
        _execute = execute;
        _canexecute = canexecute;
    }

    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, new EventArgs());
    }

    public bool CanExecute(object? parameter)
    {
        return _canexecute(parameter);
    }

    public void Execute(object? parameter)
    {
        _execute(parameter);
    }
}
