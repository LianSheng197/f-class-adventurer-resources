using System;

namespace UniRx.Operators
{
	internal class DelaySubscriptionObservable<T> : OperatorObservableBase<T>
	{
		private readonly IObservable<T> source;

		private readonly IScheduler scheduler;

		private readonly TimeSpan? dueTimeT;

		private readonly DateTimeOffset? dueTimeD;

		public DelaySubscriptionObservable(IObservable<T> source, TimeSpan dueTime, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		public DelaySubscriptionObservable(IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
