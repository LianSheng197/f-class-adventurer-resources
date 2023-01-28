using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace WebSocketSharp.Server
{
	[DefaultMember("Item")]
	public class WebSocketServiceManager
	{
		private bool _clean;

		private Dictionary<string, WebSocketServiceHost> _hosts;

		private Logger _logger;

		private ServerState _state;

		private object _sync;

		private TimeSpan _waitTime;

		public int Count => 0;

		public IEnumerable<WebSocketServiceHost> Hosts => null;

		public WebSocketServiceHost Item => null;

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

		public IEnumerable<string> Paths => null;

		public int SessionCount => 0;

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

		internal WebSocketServiceManager()
		{
		}

		internal WebSocketServiceManager(Logger logger)
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

		private Dictionary<string, Dictionary<string, bool>> broadping(byte[] frameAsBytes, TimeSpan timeout)
		{
			return null;
		}

		internal void Add<TBehavior>(string path, Func<TBehavior> initializer) where TBehavior : WebSocketBehavior
		{
		}

		internal bool InternalTryGetServiceHost(string path, out WebSocketServiceHost host)
		{
			host = null;
			return false;
		}

		internal bool Remove(string path)
		{
			return false;
		}

		internal void Start()
		{
		}

		internal void Stop(CloseEventArgs e, bool send, bool receive)
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

		public Dictionary<string, Dictionary<string, bool>> Broadping()
		{
			return null;
		}

		public Dictionary<string, Dictionary<string, bool>> Broadping(string message)
		{
			return null;
		}

		public bool TryGetServiceHost(string path, out WebSocketServiceHost host)
		{
			host = null;
			return false;
		}
	}
}
