using System;

namespace UniRx.Operators
{
	internal abstract class NthZipLatestObserverBase<T> : OperatorObserverBase<T, T>, IZipLatestObservable
	{
		private readonly int length;

		private readonly bool[] isStarted;

		private readonly bool[] isCompleted;

		public NthZipLatestObserverBase(int length, IObserver<T> observer, IDisposable cancel)
		{
			((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
		}

		public abstract T GetResult();

		public void Publish(int index)
		{
		}

		public void Done(int index)
		{
		}

		public void Fail(Exception error)
		{
		}
	}
}
