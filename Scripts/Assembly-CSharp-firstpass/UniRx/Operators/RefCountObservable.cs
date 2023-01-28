using System;

namespace UniRx.Operators
{
	internal class RefCountObservable<T> : OperatorObservableBase<T>
	{
		private class RefCount : OperatorObserverBase<T, T>
		{
			private readonly RefCountObservable<T> parent;

			public RefCount(RefCountObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private readonly IConnectableObservable<T> source;

		private readonly object gate;

		private int refCount;

		private IDisposable connection;

		public RefCountObservable(IConnectableObservable<T> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
