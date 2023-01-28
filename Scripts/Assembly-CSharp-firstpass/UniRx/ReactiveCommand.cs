using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public class ReactiveCommand : ReactiveCommand<Unit>
	{
		public ReactiveCommand()
		{
			((ReactiveCommand<>)(object)this)._002Ector();
		}

		public ReactiveCommand(IObservable<bool> canExecuteSource, bool initialValue = true)
		{
			((ReactiveCommand<>)(object)this)._002Ector();
		}

		public bool Execute()
		{
			return false;
		}

		public void ForceExecute()
		{
		}
	}
	public class ReactiveCommand<T> : IReactiveCommand<T>, IObservable<T>, IDisposable
	{
		private readonly Subject<T> trigger;

		private readonly IDisposable canExecuteSubscription;

		private ReactiveProperty<bool> canExecute;

		public IReadOnlyReactiveProperty<bool> CanExecute => null;

		public bool IsDisposed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ReactiveCommand()
		{
		}

		public ReactiveCommand(IObservable<bool> canExecuteSource, bool initialValue = true)
		{
		}

		public bool Execute(T parameter)
		{
			return false;
		}

		public void ForceExecute(T parameter)
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
