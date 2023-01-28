using System;
using System.Collections.Generic;

namespace UniRx.Operators
{
	internal class ToObservableObservable<T> : OperatorObservableBase<T>
	{
		private class ToObservable : OperatorObserverBase<T, T>
		{
			private readonly ToObservableObservable<T> parent;

			public ToObservable(ToObservableObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public IDisposable Run()
			{
				return null;
			}

			public override void OnNext(T value)
			{
			}

			public override void OnError(Exception error)
			{
			}

			public override void OnCompleted()
			{
			}
		}

		private readonly IEnumerable<T> source;

		private readonly IScheduler scheduler;

		public ToObservableObservable(IEnumerable<T> source, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
