using System;
using System.Collections.Generic;

namespace UniRx.Operators
{
	internal class ObserveOnObservable<T> : OperatorObservableBase<T>
	{
		private class ObserveOn : OperatorObserverBase<T, T>
		{
			private readonly ObserveOnObservable<T> parent;

			private readonly LinkedList<IDisposable> scheduleDisposables;

			private bool isDisposed;

			public ObserveOn(ObserveOnObservable<T> parent, IObserver<T> observer, IDisposable cancel)
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

		private class ObserveOn_ : OperatorObserverBase<T, T>
		{
			private readonly ObserveOnObservable<T> parent;

			private readonly ISchedulerQueueing scheduler;

			private readonly BooleanDisposable isDisposed;

			private readonly Action<T> onNext;

			public ObserveOn_(ObserveOnObservable<T> parent, ISchedulerQueueing scheduler, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public IDisposable Run()
			{
				return null;
			}

			private void OnNext_(T value)
			{
			}

			private void OnError_(Exception error)
			{
			}

			private void OnCompleted_(Unit _)
			{
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

		private readonly IScheduler scheduler;

		public ObserveOnObservable(IObservable<T> source, IScheduler scheduler)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
