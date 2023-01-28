using System;

namespace UniRx.Operators
{
	internal class ForEachAsyncObservable<T> : OperatorObservableBase<Unit>
	{
		private class ForEachAsync : OperatorObserverBase<T, Unit>
		{
			private readonly ForEachAsyncObservable<T> parent;

			public ForEachAsync(ForEachAsyncObservable<T> parent, IObserver<Unit> observer, IDisposable cancel)
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

		private class ForEachAsync_ : OperatorObserverBase<T, Unit>
		{
			private readonly ForEachAsyncObservable<T> parent;

			private int index;

			public ForEachAsync_(ForEachAsyncObservable<T> parent, IObserver<Unit> observer, IDisposable cancel)
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

		private readonly Action<T> onNext;

		private readonly Action<T, int> onNextWithIndex;

		public ForEachAsyncObservable(IObservable<T> source, Action<T> onNext)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		public ForEachAsyncObservable(IObservable<T> source, Action<T, int> onNext)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
