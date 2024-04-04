using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cbb.core
{
    public class RouteCommands : ICommand
    {
        private Action mAction = null;
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RouteCommands(Action action) 
        { 
            mAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mAction();
        }
    }
}
