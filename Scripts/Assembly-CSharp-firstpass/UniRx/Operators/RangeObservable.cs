using System;

namespace UniRx.Operators
{
	internal class RangeObservable : OperatorObservableBase<int>
	{
		private class Range : OperatorObserverBase<int, int>
		{
			public Range(IObserver<int> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public override void OnNext(int value)
			{
			}

			public override void OnError(Exception error)
			{
			}

			public override void OnCompleted()
			{
			}
		}

		private readonly int start;

		private readonly int count;

		private readonly IScheduler scheduler;

		public RangeObservable(int start, int count, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<int> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
