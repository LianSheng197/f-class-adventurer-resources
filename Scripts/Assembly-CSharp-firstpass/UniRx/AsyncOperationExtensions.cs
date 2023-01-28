using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx
{
	public static class AsyncOperationExtensions
	{
		[CompilerGenerated]
		private sealed class _003CAsObservableCore_003Ed__2<T> : IEnumerator<object>, IEnumerator, IDisposable where T : AsyncOperation
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IProgress<float> reportProgress;

			public T asyncOperation;

			public IObserver<T> observer;

			public CancellationToken cancel;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAsObservableCore_003Ed__2(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public static IObservable<AsyncOperation> AsObservable(this AsyncOperation asyncOperation, IProgress<float> progress = null)
		{
			return null;
		}

		public static IObservable<T> AsAsyncOperationObservable<T>(this T asyncOperation, IProgress<float> progress = null) where T : AsyncOperation
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAsObservableCore_003Ed__2<>))]
		private static IEnumerator AsObservableCore<T>(T asyncOperation, IObserver<T> observer, IProgress<float> reportProgress, CancellationToken cancel) where T : AsyncOperation
		{
			return null;
		}
	}
}
