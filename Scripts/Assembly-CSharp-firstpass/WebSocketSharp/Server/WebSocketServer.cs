using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public class WebSocketServer
	{
		private IPAddress _address;

		private AuthenticationSchemes _authSchemes;

		private static readonly string _defaultRealm;

		private bool _dnsStyle;

		private string _hostname;

		private TcpListener _listener;

		private Logger _logger;

		private int _port;

		private string _realm;

		private Thread _receiveThread;

		private bool _reuseAddress;

		private bool _secure;

		private WebSocketServiceManager _services;

		private ServerSslConfiguration _sslConfig;

		private ServerState _state;

		private object _sync;

		private Func<IIdentity, WebSocketSharp.Net.NetworkCredential> _userCredFinder;

		public IPAddress Address => null;

		public AuthenticationSchemes AuthenticationSchemes
		{
			get
			{
				return default(AuthenticationSchemes);
			}
			set
			{
			}
		}

		public bool IsListening => false;

		public bool IsSecure => false;

		public bool KeepClean
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Logger Log => null;

		public int Port => 0;

		public string Realm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ReuseAddress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ServerSslConfiguration SslConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Func<IIdentity, WebSocketSharp.Net.NetworkCredential> UserCredentialsFinder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		public WebSocketServiceManager WebSocketServices => null;

		static WebSocketServer()
		{
		}

		public WebSocketServer()
		{
		}

		public WebSocketServer(int port)
		{
		}

		public WebSocketServer(string url)
		{
		}

		public WebSocketServer(int port, bool secure)
		{
		}

		public WebSocketServer(IPAddress address, int port)
		{
		}

		public WebSocketServer(IPAddress address, int port, bool secure)
		{
		}

		private void abort()
		{
		}

		private string checkIfCertificateExists()
		{
			return null;
		}

		private string getRealm()
		{
			return null;
		}

		private void init(string hostname, IPAddress address, int port, bool secure)
		{
		}

		private void processRequest(TcpListenerWebSocketContext context)
		{
		}

		private void receiveRequest()
		{
		}

		private void startReceiving()
		{
		}

		private void stopReceiving(int millisecondsTimeout)
		{
		}

		private static bool tryCreateUri(string uriString, out Uri result, out string message)
		{
			result = null;
			message = null;
			return false;
		}

		public void AddWebSocketService<TBehavior>(string path, Func<TBehavior> initializer) where TBehavior : WebSocketBehavior
		{
		}

		public void AddWebSocketService<TBehaviorWithNew>(string path) where TBehaviorWithNew : WebSocketBehavior, new()
		{
		}

		public bool RemoveWebSocketService(string path)
		{
			return false;
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Stop(ushort code, string reason)
		{
		}

		public void Stop(CloseStatusCode code, string reason)
		{
		}
	}
}
