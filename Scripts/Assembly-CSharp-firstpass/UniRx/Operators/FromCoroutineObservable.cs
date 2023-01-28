using System;
using System.Collections;

namespace UniRx.Operators
{
	internal class FromCoroutineObservable<T> : OperatorObservableBase<T>
	{
		private class FromCoroutine : OperatorObserverBase<T, T>
		{
			public FromCoroutine(IObserver<T> observer, IDisposable cancel)
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

		private readonly Func<IObserver<T>, CancellationToken, IEnumerator> coroutine;

		public FromCoroutineObservable(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
