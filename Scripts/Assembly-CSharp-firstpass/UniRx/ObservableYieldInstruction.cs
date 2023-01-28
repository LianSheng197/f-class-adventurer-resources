using System;
using System.Collections;
using System.Collections.Generic;

namespace UniRx
{
	public class ObservableYieldInstruction<T> : IEnumerator<T>, IEnumerator, IDisposable, ICustomYieldInstructionErrorHandler
	{
		private class ToYieldInstruction : IObserver<T>
		{
			private readonly ObservableYieldInstruction<T> parent;

			public ToYieldInstruction(ObservableYieldInstruction<T> parent)
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

		private readonly IDisposable subscription;

		private readonly CancellationToken cancel;

		private bool reThrowOnError;

		private T current;

		private T result;

		private bool moveNext;

		private bool hasResult;

		private Exception error;

		public bool HasError => false;

		public bool HasResult => false;

		public bool IsCanceled => false;

		public bool IsDone => false;

		public T Result => default(T);

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent => default(T);

		private object System_002ECollections_002EIEnumerator_002ECurrent => null;

		public Exception Error => null;

		private bool UniRx_002EICustomYieldInstructionErrorHandler_002EIsReThrowOnError => false;

		public ObservableYieldInstruction(IObservable<T> source, bool reThrowOnError, CancellationToken cancel)
		{
		}

		private bool System_002ECollections_002EIEnumerator_002EMoveNext()
		{
			return false;
		}

		private void UniRx_002EICustomYieldInstructionErrorHandler_002EForceDisableRethrowOnError()
		{
		}

		private void UniRx_002EICustomYieldInstructionErrorHandler_002EForceEnableRethrowOnError()
		{
		}

		public void Dispose()
		{
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}
}
