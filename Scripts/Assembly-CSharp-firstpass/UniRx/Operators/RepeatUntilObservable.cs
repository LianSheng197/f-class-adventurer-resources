using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UniRx.Operators
{
	internal class RepeatUntilObservable<T> : OperatorObservableBase<T>
	{
		private class RepeatUntil : OperatorObserverBase<T, T>
		{
			[CompilerGenerated]
			private sealed class _003CSubscribeAfterEndOfFrame_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public SingleAssignmentDisposable d;

				public GameObject lifeTimeChecker;

				public IObservable<T> source;

				public IObserver<T> observer;

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
				public _003CSubscribeAfterEndOfFrame_003Ed__13(int _003C_003E1__state)
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

			private readonly RepeatUntilObservable<T> parent;

			private readonly object gate;

			private IEnumerator<IObservable<T>> e;

			private SerialDisposable subscription;

			private SingleAssignmentDisposable schedule;

			private Action nextSelf;

			private bool isStopped;

			private bool isDisposed;

			private bool isFirstSubscribe;

			private IDisposable stopper;

			public RepeatUntil(RepeatUntilObservable<T> parent, IObserver<T> observer, IDisposable cancel)
			{
				((OperatorObserverBase<, >)(object)this)._002Ector((IObserver<TResult>)null, (IDisposable)null);
			}

			public IDisposable Run()
			{
				return null;
			}

			private void RecursiveRun(Action self)
			{
			}

			[IteratorStateMachine(typeof(RepeatUntilObservable<>.RepeatUntil._003CSubscribeAfterEndOfFrame_003Ed__13))]
			private static IEnumerator SubscribeAfterEndOfFrame(SingleAssignmentDisposable d, IObservable<T> source, IObserver<T> observer, GameObject lifeTimeChecker)
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

		private readonly IEnumerable<IObservable<T>> sources;

		private readonly IObservable<Unit> trigger;

		private readonly GameObject lifeTimeChecker;

		public RepeatUntilObservable(IEnumerable<IObservable<T>> sources, IObservable<Unit> trigger, GameObject lifeTimeChecker)
		{
			((OperatorObservableBase<>)(object)this)._002Ector(isRequiredSubscribeOnCurrentThread: false);
		}

		protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
		{
			return null;
		}
	}
}
