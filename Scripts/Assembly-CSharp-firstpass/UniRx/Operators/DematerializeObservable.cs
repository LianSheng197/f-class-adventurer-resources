using System;

namespace UniRx.Operators
{
	internal class DematerializeObservable<T> : OperatorObservableBase<T>
	{
		private class Dematerialize : OperatorObserverBase<Notification<T>, T>
		{
			private readonly DematerializeObservable<T> parent;

			public Dematerialize(DematerializeObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public IDisposable Run()
			{
				return null;
			}

			public override void OnNext(Notification<T> value)
			{
			}

			public override void OnError(Exception error)
			{
			}

			public override void OnCompleted()
			{
			}
		}

		private readonly IObservable<Notification<T>> source;

		public DematerializeObservable(IObservable<Notification<T>> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
