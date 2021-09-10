using System;
using System.Windows.Input;

namespace Lol.Foundation.Mvvm
{
	public class RelayCommand<T> : ICommand
	{
		readonly Action<T> _execute = null;
		readonly Predicate<T> _canExecute = null;

		#region Constructors

		public RelayCommand(Action<T> execute)
			: this(execute, null)
		{
		}

		public RelayCommand(Action<T> execute, Predicate<T> canExecute)
		{
			_execute = execute ?? throw new ArgumentNullException("execute");
			_canExecute = canExecute;
		}
		#endregion

		#region CanExecute

		public bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute((T)parameter);
		}
		#endregion

		#region CanExecuteChanged

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
		#endregion

		#region Execute
		
		public void Execute(object parameter)
		{
			_execute((T)parameter);
		}
		#endregion
	}
}
