using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UniRx;

namespace socket.io
{
	public class SocketManager : MonoSingleton<SocketManager>
	{
		private SocketInitializer _socketInit;

		private readonly List<UniRx.Tuple<Socket, bool, int, DateTime>> _connectRequests;

		private readonly Dictionary<string, WebSocketTrigger> _webSocketTriggers;

		private IDisposable _cancelConnectRequest;

		public int TimeOut
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
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
			set
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
			set
			{
			}
		}

		public int ReconnectionDelay
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void CleanUp()
		{
		}

		public void Connect(Socket socket)
		{
		}

		public void Reconnect(Socket socket, int reconnectionAttempts)
		{
		}

		private void Awake()
		{
		}

		public void RegisterWebSocketTrigger(string baseUrl, WebSocketTrigger webSocketTrigger)
		{
		}

		public WebSocketTrigger GetWebSocketTrigger(string url)
		{
			return null;
		}

		public Socket GetSocket(string url)
		{
			return null;
		}

		private void Update()
		{
		}

		public SocketManager()
		{
			((MonoSingleton<>)(object)this)._002Ector();
		}
	}
}
