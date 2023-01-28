using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;

namespace socket.io
{
	public class SocketInitializer : MonoBehaviour
	{
		[Serializable]
		private struct PollingUrlAnswer
		{
			public string sid;

			public int pingInterval;

			public int pingTimeout;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public WebSocketTrigger webSocketTrigger;

			public Socket capturedSocket;

			internal bool _003CInitCore_003Eb__0()
			{
				return false;
			}

			internal bool _003CInitCore_003Eb__1()
			{
				return false;
			}

			internal void _003CInitCore_003Eb__2(string r)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInitCore_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SocketInitializer _003C_003E4__this;

			public CancellationToken cancelToken;

			public IObserver<Socket> observer;

			private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CInitCore_003Ed__21(int _003C_003E1__state)
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

		private readonly Dictionary<string, string> _urlQueries;

		public Socket Socket
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

		public bool Reconnection
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int ReconnectionAttempts
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string BaseUrl => null;

		public string PollingUrl => null;

		public string WebSocketUrl => null;

		public IObservable<Socket> InitAsObservable(Socket socket, bool reconnection, int reconnectionAttempts)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInitCore_003Ed__21))]
		private IEnumerator InitCore(IObserver<Socket> observer, CancellationToken cancelToken)
		{
			return null;
		}

		public void CleanUp()
		{
		}
	}
}
