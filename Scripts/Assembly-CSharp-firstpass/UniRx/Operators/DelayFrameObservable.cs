using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UniRx.Operators
{
	internal class DelayFrameObservable<T> : OperatorObservableBase<T>
	{
		private class DelayFrame : OperatorObserverBase<T, T>
		{
			[CompilerGenerated]
			private sealed class _003CDrainQueue_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public DelayFrame _003C_003E4__this;

				public int frameCount;

				public Queue<T> q;

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
				public _003CDrainQueue_003Ed__14(int _003C_003E1__state)
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

			private readonly DelayFrameObservable<T> parent;

			private readonly object gate;

			private readonly QueuePool pool;

			private int runningEnumeratorCount;

			private bool readyDrainEnumerator;

			private bool running;

			private IDisposable sourceSubscription;

			private Queue<T> currentQueueReference;

			private bool calledCompleted;

			private bool hasError;

			private Exception error;

			private BooleanDisposable cancelationToken;

			public DelayFrame(DelayFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public IDisposable Run()
			{
				return null;
			}

			[IteratorStateMachine(typeof(DelayFrameObservable<>.DelayFrame._003CDrainQueue_003Ed__14))]
			private IEnumerator DrainQueue(Queue<T> q, int frameCount)
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

		private class QueuePool
		{
			private readonly object gate;

			private readonly Queue<Queue<T>> pool;

			public Queue<T> Get()
			{
				return null;
			}

			public void Return(Queue<T> q)
			{
			}
		}

		private readonly IObservable<T> source;

		private readonly int frameCount;

		private readonly FrameCountType frameCountType;

		public DelayFrameObservable(IObservable<T> source, int frameCount, FrameCountType frameCountType)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
