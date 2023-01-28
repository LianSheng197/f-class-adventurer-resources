using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Google
{
	public class Future<T>
	{
		[CompilerGenerated]
		private sealed class _003CWaitForResult_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Future<T> _003C_003E4__this;

			public TaskCompletionSource<T> tcs;

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
			public _003CWaitForResult_003Ed__8(int _003C_003E1__state)
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

		private FutureAPIImpl<T> apiImpl;

		public bool Pending => false;

		private GoogleSignInStatusCode Status => default(GoogleSignInStatusCode);

		private T Result => default(T);

		internal Future(FutureAPIImpl<T> impl)
		{
		}

		[IteratorStateMachine(typeof(Future<>._003CWaitForResult_003Ed__8))]
		internal IEnumerator WaitForResult(TaskCompletionSource<T> tcs)
		{
			return null;
		}
	}
}
