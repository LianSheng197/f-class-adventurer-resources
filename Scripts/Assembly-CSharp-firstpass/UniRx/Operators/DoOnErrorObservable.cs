using System;

namespace UniRx.Operators
{
	internal class DoOnErrorObservable<T> : OperatorObservableBase<T>
	{
		private class DoOnError : OperatorObserverBase<T, T>
		{
			private readonly DoOnErrorObservable<T> parent;

			public DoOnError(DoOnErrorObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private readonly Action<Exception> onError;

		public DoOnErrorObservable(IObservable<T> source, Action<Exception> onError)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
