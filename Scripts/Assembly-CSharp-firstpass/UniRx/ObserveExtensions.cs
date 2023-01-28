using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Triggers;
using UnityEngine;

namespace UniRx
{
	public static class ObserveExtensions
	{
		[CompilerGenerated]
		private sealed class _003CEmptyEnumerator_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CEmptyEnumerator_003Ed__3(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPublishPocoValueChanged_003Ed__4<TSource, TProperty> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TProperty firstValue;

			public WeakReference sourceReference;

			public Func<TSource, TProperty> propertySelector;

			public IObserver<TProperty> observer;

			public IEqualityComparer<TProperty> comparer;

			public CancellationToken cancellationToken;

			private TProperty _003CprevValue_003E5__2;

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
			public _003CPublishPocoValueChanged_003Ed__4(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPublishUnityObjectValueChanged_003Ed__5<TSource, TProperty> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TProperty firstValue;

			public UnityEngine.Object unityObject;

			public bool fastDestroyCheck;

			public Func<TSource, TProperty> propertySelector;

			public IObserver<TProperty> observer;

			public IEqualityComparer<TProperty> comparer;

			public CancellationToken cancellationToken;

			private TProperty _003CprevValue_003E5__2;

			private TSource _003Csource_003E5__3;

			private ObservableDestroyTrigger _003CdestroyTrigger_003E5__4;

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
			public _003CPublishUnityObjectValueChanged_003Ed__5(int _003C_003E1__state)
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

		public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType = FrameCountType.Update, bool fastDestroyCheck = false) where TSource : class
		{
			return null;
		}

		public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType, IEqualityComparer<TProperty> comparer) where TSource : class
		{
			return null;
		}

		public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType, IEqualityComparer<TProperty> comparer, bool fastDestroyCheck) where TSource : class
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEmptyEnumerator_003Ed__3))]
		private static IEnumerator EmptyEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPublishPocoValueChanged_003Ed__4<, >))]
		private static IEnumerator PublishPocoValueChanged<TSource, TProperty>(WeakReference sourceReference, TProperty firstValue, Func<TSource, TProperty> propertySelector, IEqualityComparer<TProperty> comparer, IObserver<TProperty> observer, CancellationToken cancellationToken)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPublishUnityObjectValueChanged_003Ed__5<, >))]
		private static IEnumerator PublishUnityObjectValueChanged<TSource, TProperty>(UnityEngine.Object unityObject, TProperty firstValue, Func<TSource, TProperty> propertySelector, IEqualityComparer<TProperty> comparer, IObserver<TProperty> observer, CancellationToken cancellationToken, bool fastDestroyCheck)
		{
			return null;
		}

		private static ObservableDestroyTrigger GetOrAddDestroyTrigger(GameObject go)
		{
			return null;
		}
	}
}
