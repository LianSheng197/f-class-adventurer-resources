using System;

namespace UniRx.Operators
{
	internal class TimerObservable : OperatorObservableBase<long>
	{
		private class Timer : OperatorObserverBase<long, long>
		{
			private long index;

			public Timer(IObserver<long> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public void OnNext()
			{
			}

			public override void OnNext(long value)
			{
			}

			public override void OnError(Exception error)
			{
			}

			public override void OnCompleted()
			{
			}
		}

		private readonly DateTimeOffset? dueTimeA;

		private readonly TimeSpan? dueTimeB;

		private readonly TimeSpan? period;

		private readonly IScheduler scheduler;

		public TimerObservable(DateTimeOffset dueTime, TimeSpan? period, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		public TimerObservable(TimeSpan dueTime, TimeSpan? period, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<long> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
