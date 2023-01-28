using System;

namespace UniRx.Operators
{
	internal class DoObserverObservable<T> : OperatorObservableBase<T>
	{
		private class Do : OperatorObserverBase<T, T>
		{
			private readonly DoObserverObservable<T> parent;

			public Do(DoObserverObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public IDisposable Run()
			{
				return null;
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

		private readonly IObserver<T> observer;

		public DoObserverObservable(IObservable<T> source, IObserver<T> observer)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
