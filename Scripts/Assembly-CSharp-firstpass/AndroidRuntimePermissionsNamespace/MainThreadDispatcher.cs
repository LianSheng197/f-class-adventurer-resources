using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AndroidRuntimePermissionsNamespace
{
	public class MainThreadDispatcher : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CExecuteOnMainThreadCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action functionToExecute;

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
			public _003CExecuteOnMainThreadCoroutine_003Ed__4(int _003C_003E1__state)
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

		private static MainThreadDispatcher m_instance;

		private static MainThreadDispatcher Instance => null;

		public static void ExecuteOnMainThread(Action functionToExecute)
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteOnMainThreadCoroutine_003Ed__4))]
		private static IEnumerator ExecuteOnMainThreadCoroutine(Action functionToExecute)
		{
			return null;
		}
	}
}
