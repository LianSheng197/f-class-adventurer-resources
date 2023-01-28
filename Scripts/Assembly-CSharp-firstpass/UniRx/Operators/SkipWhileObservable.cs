using System;

namespace UniRx.Operators
{
	internal class SkipWhileObservable<T> : OperatorObservableBase<T>
	{
		private class SkipWhile : OperatorObserverBase<T, T>
		{
			private readonly SkipWhileObservable<T> parent;

			private bool endSkip;

			public SkipWhile(SkipWhileObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private class SkipWhile_ : OperatorObserverBase<T, T>
		{
			private readonly SkipWhileObservable<T> parent;

			private bool endSkip;

			private int index;

			public SkipWhile_(SkipWhileObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private readonly Func<T, bool> predicate;

		private readonly Func<T, int, bool> predicateWithIndex;

		public SkipWhileObservable(IObservable<T> source, Func<T, bool> predicate)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		public SkipWhileObservable(IObservable<T> source, Func<T, int, bool> predicateWithIndex)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
