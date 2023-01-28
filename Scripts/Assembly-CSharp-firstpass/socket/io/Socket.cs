using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace socket.io
{
	public class Socket : MonoBehaviour
	{
		private int _idGenerator;

		private readonly Dictionary<int, Action<string>> _acks;

		private readonly Dictionary<string, Action<string>> _handlers;

		private WebSocketTrigger _webSocketTrigger;

		public Action OnConnect
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

		public Action OnConnectTimeOut
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

		public Action OnReconnectAttempt
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

		public Action OnReconnectFailed
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

		public Action OnDisconnect
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

		public Action<int> OnReconnect
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

		public Action<int> OnReconnecting
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

		public Action<Exception> OnConnectError
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

		public Action<Exception> OnReconnectError
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

		public Uri Url
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public string Namespace => null;

		public bool HasNamespace => false;

		public bool IsConnected => false;

		protected WebSocketTrigger WebSocketTrigger => null;

		public static Socket Connect(string url)
		{
			return null;
		}

		public void On(string eventName, Action<string> callback)
		{
		}

		public void On(string eventName, Action callback)
		{
		}

		public void On(string eventName, Action<int> callback)
		{
		}

		public void On(string eventName, Action<Exception> callback)
		{
		}

		public void Off(string eventName)
		{
		}

		public void On(SystemEvents @event, Action callback)
		{
		}

		public void On(SystemEvents @event, Action<int> callback)
		{
		}

		public void On(SystemEvents @event, Action<Exception> callback)
		{
		}

		public void Off(SystemEvents @event)
		{
		}

		public void Emit(string eventName)
		{
		}

		public void Emit(string eventName, string data)
		{
		}

		public void EmitJson(string eventName, string jsonData)
		{
		}

		public void Emit(string eventName, string data, Action<string> ack)
		{
		}

		public void EmitJson(string eventName, string jsonData, Action<string> ack)
		{
		}

		public void OnRecvWebSocketPacket(string pkt)
		{
		}

		private void DispatchPacket(Packet pkt)
		{
		}
	}
}
