using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class ReactiveProperty<T> : IReactiveProperty<T>, IReadOnlyReactiveProperty<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>
	{
		private class ReactivePropertyObserver : IObserver<T>
		{
			private readonly ReactiveProperty<T> parent;

			private int isStopped;

			public ReactivePropertyObserver(ReactiveProperty<T> parent)
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

		[NonSerialized]
		private bool canPublishValueOnSubscribe;

		[NonSerialized]
		private bool isDisposed;

		[SerializeField]
		private T value;

		[NonSerialized]
		private Subject<T> publisher;

		[NonSerialized]
		private IDisposable sourceConnection;

		[NonSerialized]
		private Exception lastException;

		protected virtual IEqualityComparer<T> EqualityComparer => null;

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public bool HasValue => false;

		public ReactiveProperty()
		{
		}

		public ReactiveProperty(T initialValue)
		{
		}

		public ReactiveProperty(IObservable<T> source)
		{
		}

		public ReactiveProperty(IObservable<T> source, T initialValue)
		{
		}

		protected virtual void SetValue(T value)
		{
		}

		public void SetValueAndForceNotify(T value)
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
