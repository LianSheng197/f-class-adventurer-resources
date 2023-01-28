using System;
using UnityEngine.UI;

namespace UniRx
{
	public static class ReactiveCommandExtensions
	{
		public static ReactiveCommand ToReactiveCommand(this IObservable<bool> canExecuteSource, bool initialValue = true)
		{
			return null;
		}

		public static ReactiveCommand<T> ToReactiveCommand<T>(this IObservable<bool> canExecuteSource, bool initialValue = true)
		{
			return null;
		}

		public static IDisposable BindTo(this ReactiveCommand<Unit> command, Button button)
		{
			return null;
		}

		public static IDisposable BindToOnClick(this ReactiveCommand<Unit> command, Button button, Action<Unit> onClick)
		{
			return null;
		}

		public static IDisposable BindToButtonOnClick(this IObservable<bool> canExecuteSource, Button button, Action<Unit> onClick, bool initialValue = true)
		{
			return null;
		}
	}
}
