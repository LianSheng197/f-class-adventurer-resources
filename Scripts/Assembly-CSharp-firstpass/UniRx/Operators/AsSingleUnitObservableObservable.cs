using System;

namespace UniRx.Operators
{
	internal class AsSingleUnitObservableObservable<T> : OperatorObservableBase<Unit>
	{
		private class AsSingleUnitObservable : OperatorObserverBase<T, Unit>
		{
			public AsSingleUnitObservable(IObserver<Unit> observer, IDisposable cancel)
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

		private readonly IObservable<T> source;

		public AsSingleUnitObservableObservable(IObservable<T> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
