using System;

namespace UniRx.Operators
{
	internal class NeverObservable<T> : OperatorObservableBase<T>
	{
		public NeverObservable()
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
