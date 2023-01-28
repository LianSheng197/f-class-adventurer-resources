using System;
using System.Collections.Generic;

namespace UniRx.Operators
{
	internal class ToArrayObservable<TSource> : OperatorObservableBase<TSource[]>
	{
		private class ToArray : OperatorObserverBase<TSource, TSource[]>
		{
			private readonly List<TSource> list;

			public ToArray(IObserver<TSource[]> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public override void OnNext(TSource value)
			{
			}

			public override void OnError(Exception error)
			{
			}

			public override void OnCompleted()
			{
			}
		}

		private readonly IObservable<TSource> source;

		public ToArrayObservable(IObservable<TSource> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<TSource[]> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
