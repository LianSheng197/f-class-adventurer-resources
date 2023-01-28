using System;

namespace UniRx.Operators
{
	internal class SynchronizeObservable<T> : OperatorObservableBase<T>
	{
		private class Synchronize : OperatorObserverBase<T, T>
		{
			private readonly SynchronizeObservable<T> parent;

			public Synchronize(SynchronizeObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private readonly object gate;

		public SynchronizeObservable(IObservable<T> source, object gate)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
