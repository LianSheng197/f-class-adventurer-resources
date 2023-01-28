using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Triggers;
using UnityEngine;

namespace UniRx
{
	public static class DisposableExtensions
	{
		[CompilerGenerated]
		private sealed class _003CMonitorTriggerHealth_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ObservableDestroyTrigger trigger;

			public GameObject targetGameObject;

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
			public _003CMonitorTriggerHealth_003Ed__2(int _003C_003E1__state)
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

		public static T AddTo<T>(this T disposable, ICollection<IDisposable> container) where T : IDisposable
		{
			return default(T);
		}

		public static T AddTo<T>(this T disposable, GameObject gameObject) where T : IDisposable
		{
			return default(T);
		}

		[IteratorStateMachine(typeof(_003CMonitorTriggerHealth_003Ed__2))]
		private static IEnumerator MonitorTriggerHealth(ObservableDestroyTrigger trigger, GameObject targetGameObject)
		{
			return null;
		}

		public static T AddTo<T>(this T disposable, Component gameObjectComponent) where T : IDisposable
		{
			return default(T);
		}

		public static T AddTo<T>(this T disposable, ICollection<IDisposable> container, GameObject gameObject) where T : IDisposable
		{
			return default(T);
		}

		public static T AddTo<T>(this T disposable, ICollection<IDisposable> container, Component gameObjectComponent) where T : IDisposable
		{
			return default(T);
		}
	}
}
