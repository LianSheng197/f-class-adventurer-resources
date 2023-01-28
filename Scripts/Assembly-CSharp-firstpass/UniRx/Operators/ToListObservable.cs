using System;
using System.Collections.Generic;

namespace UniRx.Operators
{
	internal class ToListObservable<TSource> : OperatorObservableBase<IList<TSource>>
	{
		private class ToList : OperatorObserverBase<TSource, IList<TSource>>
		{
			private readonly List<TSource> list;

			public ToList(IObserver<IList<TSource>> observer, IDisposable cancel)
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

		public ToListObservable(IObservable<TSource> source)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<IList<TSource>> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
