using System;

namespace UniRx.Operators
{
	internal class DoOnTerminateObservable<T> : OperatorObservableBase<T>
	{
		private class DoOnTerminate : OperatorObserverBase<T, T>
		{
			private readonly DoOnTerminateObservable<T> parent;

			public DoOnTerminate(DoOnTerminateObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private readonly Action onTerminate;

		public DoOnTerminateObservable(IObservable<T> source, Action onTerminate)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
