using System;
using System.IO;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public abstract class WebSocketBehavior : IWebSocketSession
	{
		private WebSocketContext _context;

		private Func<CookieCollection, CookieCollection, bool> _cookiesValidator;

		private bool _emitOnPing;

		private string _id;

		private bool _ignoreExtensions;

		private Func<string, bool> _originValidator;

		private string _protocol;

		private WebSocketSessionManager _sessions;

		private DateTime _startTime;

		private WebSocket _websocket;

		protected Logger Log => null;

		protected WebSocketSessionManager Sessions => null;

		public WebSocketContext Context => null;

		public Func<CookieCollection, CookieCollection, bool> CookiesValidator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool EmitOnPing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string ID => null;

		public bool IgnoreExtensions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Func<string, bool> OriginValidator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Protocol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime StartTime => default(DateTime);

		public WebSocketState State => default(WebSocketState);

		private string checkHandshakeRequest(WebSocketContext context)
		{
			return null;
		}

		private void onClose(object sender, CloseEventArgs e)
		{
		}

		private void onError(object sender, ErrorEventArgs e)
		{
		}

		private void onMessage(object sender, MessageEventArgs e)
		{
		}

		private void onOpen(object sender, EventArgs e)
		{
		}

		internal void Start(WebSocketContext context, WebSocketSessionManager sessions)
		{
		}

		protected void Error(string message, Exception exception)
		{
		}

		protected virtual void OnClose(CloseEventArgs e)
		{
		}

		protected virtual void OnError(ErrorEventArgs e)
		{
		}

		protected virtual void OnMessage(MessageEventArgs e)
		{
		}

		protected virtual void OnOpen()
		{
		}

		protected void Send(byte[] data)
		{
		}

		protected void Send(FileInfo file)
		{
		}

		protected void Send(string data)
		{
		}

		protected void SendAsync(byte[] data, Action<bool> completed)
		{
		}

		protected void SendAsync(FileInfo file, Action<bool> completed)
		{
		}

		protected void SendAsync(string data, Action<bool> completed)
		{
		}

		protected void SendAsync(Stream stream, int length, Action<bool> completed)
		{
		}
	}
}
