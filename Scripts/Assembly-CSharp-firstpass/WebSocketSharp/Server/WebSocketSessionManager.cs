using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Timers;

namespace WebSocketSharp.Server
{
	[DefaultMember("Item")]
	public class WebSocketSessionManager
	{
		[CompilerGenerated]
		private sealed class _003Cget_ActiveIDs_003Ed__14 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public WebSocketSessionManager _003C_003E4__this;

			private Dictionary<string, bool>.Enumerator _003C_003E7__wrap1;

			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
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
			public _003Cget_ActiveIDs_003Ed__14(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_InactiveIDs_003Ed__20 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public WebSocketSessionManager _003C_003E4__this;

			private Dictionary<string, bool>.Enumerator _003C_003E7__wrap1;

			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
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
			public _003Cget_InactiveIDs_003Ed__20(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private bool _clean;

		private object _forSweep;

		private Logger _logger;

		private Dictionary<string, IWebSocketSession> _sessions;

		private ServerState _state;

		private bool _sweeping;

		private Timer _sweepTimer;

		private object _sync;

		private TimeSpan _waitTime;

		internal ServerState State => default(ServerState);

		public IEnumerable<string> ActiveIDs
		{
			[IteratorStateMachine(typeof(_003Cget_ActiveIDs_003Ed__14))]
			get
			{
				return null;
			}
		}

		public int Count => 0;

		public IEnumerable<string> IDs => null;

		public IEnumerable<string> InactiveIDs
		{
			[IteratorStateMachine(typeof(_003Cget_InactiveIDs_003Ed__20))]
			get
			{
				return null;
			}
		}

		public IWebSocketSession Item => null;

		public bool KeepClean
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		public IEnumerable<IWebSocketSession> Sessions => null;

		public TimeSpan WaitTime
		{
			get
			{
				return default(TimeSpan);
			}
			internal set
			{
			}
		}

		internal WebSocketSessionManager()
		{
		}

		internal WebSocketSessionManager(Logger logger)
		{
		}

		private void broadcast(Opcode opcode, byte[] data, Action completed)
		{
		}

		private void broadcast(Opcode opcode, Stream stream, Action completed)
		{
		}

		private void broadcastAsync(Opcode opcode, byte[] data, Action completed)
		{
		}

		private void broadcastAsync(Opcode opcode, Stream stream, Action completed)
		{
		}

		private static string createID()
		{
			return null;
		}

		private void setSweepTimer(double interval)
		{
		}

		private bool tryGetSession(string id, out IWebSocketSession session)
		{
			session = null;
			return false;
		}

		internal string Add(IWebSocketSession session)
		{
			return null;
		}

		internal void Broadcast(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache)
		{
		}

		internal void Broadcast(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache)
		{
		}

		internal Dictionary<string, bool> Broadping(byte[] frameAsBytes, TimeSpan timeout)
		{
			return null;
		}

		internal bool Remove(string id)
		{
			return false;
		}

		internal void Start()
		{
		}

		internal void Stop(CloseEventArgs e, byte[] frameAsBytes, bool receive)
		{
		}

		public void Broadcast(byte[] data)
		{
		}

		public void Broadcast(string data)
		{
		}

		public void BroadcastAsync(byte[] data, Action completed)
		{
		}

		public void BroadcastAsync(string data, Action completed)
		{
		}

		public void BroadcastAsync(Stream stream, int length, Action completed)
		{
		}

		public Dictionary<string, bool> Broadping()
		{
			return null;
		}

		public Dictionary<string, bool> Broadping(string message)
		{
			return null;
		}

		public void CloseSession(string id)
		{
		}

		public void CloseSession(string id, ushort code, string reason)
		{
		}

		public void CloseSession(string id, CloseStatusCode code, string reason)
		{
		}

		public bool PingTo(string id)
		{
			return false;
		}

		public bool PingTo(string message, string id)
		{
			return false;
		}

		public void SendTo(byte[] data, string id)
		{
		}

		public void SendTo(string data, string id)
		{
		}

		public void SendToAsync(byte[] data, string id, Action<bool> completed)
		{
		}

		public void SendToAsync(string data, string id, Action<bool> completed)
		{
		}

		public void SendToAsync(Stream stream, int length, string id, Action<bool> completed)
		{
		}

		public void Sweep()
		{
		}

		public bool TryGetSession(string id, out IWebSocketSession session)
		{
			session = null;
			return false;
		}
	}
}
