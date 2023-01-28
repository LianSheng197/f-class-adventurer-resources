using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx
{
	public abstract class LazyTask
	{
		public enum TaskStatus
		{
			WaitingToRun = 0,
			Running = 1,
			Completed = 2,
			Canceled = 3,
			Faulted = 4
		}

		[CompilerGenerated]
		private sealed class _003CWhenAllCore_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Coroutine[] coroutines;

			private Coroutine[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
			public _003CWhenAllCore_003Ed__11(int _003C_003E1__state)
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

		protected readonly BooleanDisposable cancellation;

		public TaskStatus Status
		{
			[CompilerGenerated]
			get
			{
				return default(TaskStatus);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public abstract Coroutine Start();

		public void Cancel()
		{
		}

		public static LazyTask<T> FromResult<T>(T value)
		{
			return null;
		}

		public static Coroutine WhenAll(params LazyTask[] tasks)
		{
			return null;
		}

		public static Coroutine WhenAll(IEnumerable<LazyTask> tasks)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWhenAllCore_003Ed__11))]
		private static IEnumerator WhenAllCore(Coroutine[] coroutines)
		{
			return null;
		}
	}
	public class LazyTask<T> : LazyTask
	{
		private readonly IObservable<T> source;

		private T result;

		public T Result => default(T);

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LazyTask(IObservable<T> source)
		{
		}

		public override Coroutine Start()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static LazyTask<T> FromResult(T value)
		{
			return null;
		}
	}
}
