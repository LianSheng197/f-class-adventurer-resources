using System;

namespace UniRx.Operators
{
	internal class MaterializeObservable<T> : OperatorObservableBase<Notification<T>>
	{
		private class Materialize : OperatorObserverBase<T, Notification<T>>
		{
			private readonly MaterializeObservable<T> parent;

			public Materialize(MaterializeObservable<T> parent, IObserver<Notification<T>> observer, IDisposable cancel)
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

		public MaterializeObservable(IObservable<T> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<Notification<T>> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
