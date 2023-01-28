using System;

namespace UniRx.Operators
{
	internal class LastObservable<T> : OperatorObservableBase<T>
	{
		private class Last : OperatorObserverBase<T, T>
		{
			private readonly LastObservable<T> parent;

			private bool notPublished;

			private T lastValue;

			public Last(LastObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
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

		private class Last_ : OperatorObserverBase<T, T>
		{
			private readonly LastObservable<T> parent;

			private bool notPublished;

			private T lastValue;

			public Last_(LastObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
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

		private readonly bool useDefault;

		private readonly Func<T, bool> predicate;

		public LastObservable(IObservable<T> source, bool useDefault)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		public LastObservable(IObservable<T> source, Func<T, bool> predicate, bool useDefault)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
