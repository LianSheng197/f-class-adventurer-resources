using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WebSocketSharp;

namespace socket.io
{
	public class WebSocketWrapper
	{
		private WebSocket _webSocket;

		private readonly Queue<byte[]> _messages;

		private readonly Queue<string> _errors;

		private readonly object _recvLock;

		public Uri Url
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

		public bool IsConnected => false;

		public WebSocketWrapper(Uri url)
		{
		}

		public void Connect()
		{
		}

		public void Close()
		{
		}

		public void Send(string data)
		{
		}

		public string Recv()
		{
			return null;
		}

		public string GetLastError()
		{
			return null;
		}

		public bool IsConnectedInternal()
		{
			return false;
		}

		private void ConnectInternal(string url)
		{
		}

		private void SendInternal(string data)
		{
		}

		private string RecvInternal()
		{
			return null;
		}

		private void CloseInternal()
		{
		}

		private string ErrorInternal()
		{
			return null;
		}
	}
}
