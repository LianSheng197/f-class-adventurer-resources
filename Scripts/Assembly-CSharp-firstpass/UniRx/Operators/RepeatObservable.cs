using System;

namespace UniRx.Operators
{
	internal class RepeatObservable<T> : OperatorObservableBase<T>
	{
		private class Repeat : OperatorObserverBase<T, T>
		{
			public Repeat(IObserver<T> observer, IDisposable cancel)
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

		private readonly T value;

		private readonly int? repeatCount;

		private readonly IScheduler scheduler;

		public RepeatObservable(T value, int? repeatCount, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
