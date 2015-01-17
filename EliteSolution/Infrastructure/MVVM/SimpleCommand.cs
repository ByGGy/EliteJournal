using System;
using System.Windows.Input;

namespace Infrastructure
{
    public class SimpleCommand : ICommand
    {
        private Action command;

        public SimpleCommand(Action command)
        {
            this.command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (this.command != null)
                this.command.Invoke();
        }
    }
}