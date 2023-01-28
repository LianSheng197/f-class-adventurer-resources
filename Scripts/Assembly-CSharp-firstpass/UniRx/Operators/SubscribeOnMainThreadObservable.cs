using System;

namespace UniRx.Operators
{
	internal class SubscribeOnMainThreadObservable<T> : OperatorObservableBase<T>
	{
		private readonly IObservable<T> source;

		private readonly IObservable<long> subscribeTrigger;

		public SubscribeOnMainThreadObservable(IObservable<T> source, IObservable<long> subscribeTrigger)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
