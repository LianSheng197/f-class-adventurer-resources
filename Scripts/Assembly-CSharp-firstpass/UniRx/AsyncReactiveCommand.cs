using System;
using System.Runtime.CompilerServices;
using UniRx.InternalUtil;

namespace UniRx
{
	public class AsyncReactiveCommand : AsyncReactiveCommand<Unit>
	{
		public AsyncReactiveCommand()
		{
			((AsyncReactiveCommand<>)(object)this)._002Ector();
		}

		public AsyncReactiveCommand(IObservable<bool> canExecuteSource)
		{
			((AsyncReactiveCommand<>)(object)this)._002Ector();
		}

		public AsyncReactiveCommand(IReactiveProperty<bool> sharedCanExecute)
		{
			((AsyncReactiveCommand<>)(object)this)._002Ector();
		}

		public IDisposable Execute()
		{
			return null;
		}
	}
	public class AsyncReactiveCommand<T> : IAsyncReactiveCommand<T>
	{
		private class Subscription : IDisposable
		{
			private readonly AsyncReactiveCommand<T> parent;

			private readonly Func<T, IObservable<Unit>> asyncAction;

			public Subscription(AsyncReactiveCommand<T> parent, Func<T, IObservable<Unit>> asyncAction)
			{
			}

			public void Dispose()
			{
			}
		}

		private ImmutableList<Func<T, IObservable<Unit>>> asyncActions;

		private readonly object gate;

		private readonly IReactiveProperty<bool> canExecuteSource;

		private readonly IReadOnlyReactiveProperty<bool> canExecute;

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

		public AsyncReactiveCommand()
		{
		}

		public AsyncReactiveCommand(IObservable<bool> canExecuteSource)
		{
		}

		public AsyncReactiveCommand(IReactiveProperty<bool> sharedCanExecute)
		{
		}

		public IDisposable Execute(T parameter)
		{
			return null;
		}

		public IDisposable Subscribe(Func<T, IObservable<Unit>> asyncAction)
		{
			return null;
		}
	}
}
