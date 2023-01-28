using System;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public abstract class WebSocketServiceHost
	{
		internal ServerState State => default(ServerState);

		public abstract bool KeepClean { get; set; }

		public abstract string Path { get; }

		public abstract WebSocketSessionManager Sessions { get; }

		public abstract Type Type { get; }

		public abstract TimeSpan WaitTime { get; set; }

		internal void Start()
		{
		}

		internal void StartSession(WebSocketContext context)
		{
		}

		internal void Stop(ushort code, string reason)
		{
		}

		protected abstract WebSocketBehavior CreateSession();
	}
	internal class WebSocketServiceHost<TBehavior> : WebSocketServiceHost where TBehavior : WebSocketBehavior
	{
		private Func<TBehavior> _initializer;

		private Logger _logger;

		private string _path;

		private WebSocketSessionManager _sessions;

		public override bool KeepClean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string Path => null;

		public override WebSocketSessionManager Sessions => null;

		public override Type Type => null;

		public override TimeSpan WaitTime
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		internal WebSocketServiceHost(string path, Func<TBehavior> initializer, Logger logger)
		{
		}

		protected override WebSocketBehavior CreateSession()
		{
			return null;
		}
	}
}
