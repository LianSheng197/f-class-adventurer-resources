using System;
using System.Collections.Generic;

namespace UniRx
{
	public class ReadOnlyReactiveProperty<T> : IReadOnlyReactiveProperty<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>
	{
		private class ReadOnlyReactivePropertyObserver : IObserver<T>
		{
			private readonly ReadOnlyReactiveProperty<T> parent;

			private int isStopped;

			public ReadOnlyReactivePropertyObserver(ReadOnlyReactiveProperty<T> parent)
			{
			}

			public void OnNext(T value)
			{
			}

			public void OnError(Exception error)
			{
			}

			public void OnCompleted()
			{
			}
		}

		private static readonly IEqualityComparer<T> defaultEqualityComparer;

		private readonly bool distinctUntilChanged;

		private bool canPublishValueOnSubscribe;

		private bool isDisposed;

		private Exception lastException;

		private T value;

		private Subject<T> publisher;

		private IDisposable sourceConnection;

		private bool isSourceCompleted;

		public T Value => default(T);

		public bool HasValue => false;

		protected virtual IEqualityComparer<T> EqualityComparer => null;

		public ReadOnlyReactiveProperty(IObservable<T> source)
		{
		}

		public ReadOnlyReactiveProperty(IObservable<T> source, bool distinctUntilChanged)
		{
		}

		public ReadOnlyReactiveProperty(IObservable<T> source, T initialValue)
		{
		}

		public ReadOnlyReactiveProperty(IObservable<T> source, T initialValue, bool distinctUntilChanged)
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool IsRequiredSubscribeOnCurrentThread()
		{
			return false;
		}
	}
}
