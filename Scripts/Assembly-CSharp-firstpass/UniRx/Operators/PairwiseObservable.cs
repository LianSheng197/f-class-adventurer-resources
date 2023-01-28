using System;

namespace UniRx.Operators
{
	internal class PairwiseObservable<T, TR> : OperatorObservableBase<TR>
	{
		private class Pairwise : OperatorObserverBase<T, TR>
		{
			private readonly PairwiseObservable<T, TR> parent;

			private T prev;

			private bool isFirst;

			public Pairwise(PairwiseObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel)
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

		private readonly Func<T, T, TR> selector;

		public PairwiseObservable(IObservable<T> source, Func<T, T, TR> selector)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel)
		{
			return null;
		}
	}
	internal class PairwiseObservable<T> : OperatorObservableBase<Pair<T>>
	{
		private class Pairwise : OperatorObserverBase<T, Pair<T>>
		{
			private T prev;

			private bool isFirst;

			public Pairwise(IObserver<Pair<T>> observer, IDisposable cancel)
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

		public PairwiseObservable(IObservable<T> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<Pair<T>> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
