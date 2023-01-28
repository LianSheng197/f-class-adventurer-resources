using System;

namespace UniRx.Operators
{
	internal class ThrowObservable<T> : OperatorObservableBase<T>
	{
		private class Throw : OperatorObserverBase<T, T>
		{
			public Throw(IObserver<T> observer, IDisposable cancel)
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

		private readonly Exception error;

		private readonly IScheduler scheduler;

		public ThrowObservable(Exception error, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
