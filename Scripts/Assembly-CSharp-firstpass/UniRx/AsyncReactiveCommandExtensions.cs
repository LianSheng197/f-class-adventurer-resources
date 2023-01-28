using System;
using UnityEngine.UI;

namespace UniRx
{
	public static class AsyncReactiveCommandExtensions
	{
		public static AsyncReactiveCommand ToAsyncReactiveCommand(this IReactiveProperty<bool> sharedCanExecuteSource)
		{
			return null;
		}

		public static AsyncReactiveCommand<T> ToAsyncReactiveCommand<T>(this IReactiveProperty<bool> sharedCanExecuteSource)
		{
			return null;
		}

		public static IDisposable BindTo(this AsyncReactiveCommand<Unit> command, Button button)
		{
			return null;
		}

		public static IDisposable BindToOnClick(this AsyncReactiveCommand<Unit> command, Button button, Func<Unit, IObservable<Unit>> asyncOnClick)
		{
			return null;
		}

		public static IDisposable BindToOnClick(this Button button, Func<Unit, IObservable<Unit>> asyncOnClick)
		{
			return null;
		}

		public static IDisposable BindToOnClick(this Button button, IReactiveProperty<bool> sharedCanExecuteSource, Func<Unit, IObservable<Unit>> asyncOnClick)
		{
			return null;
		}
	}
}
