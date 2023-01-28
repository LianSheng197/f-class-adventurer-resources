using System;

namespace UniRx.Operators
{
	internal class DeferObservable<T> : OperatorObservableBase<T>
	{
		private class Defer : OperatorObserverBase<T, T>
		{
			public Defer(IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
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

		private readonly Func<IObservable<T>> observableFactory;

		public DeferObservable(Func<IObservable<T>> observableFactory)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
