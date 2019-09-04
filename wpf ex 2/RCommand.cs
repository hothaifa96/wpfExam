using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace wpf_ex_2
{
    class RCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> executeMethod;

        Func<object, bool> canExecute;

        public RCommand(Func<object, bool> canExecute, Action<object> executeMethod)
        {
            this.executeMethod = executeMethod;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.executeMethod(parameter);
        }
    }
}
