using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public class HttpServer
	{
		private IPAddress _address;

		private string _hostname;

		private HttpListener _listener;

		private Logger _logger;

		private int _port;

		private Thread _receiveThread;

		private string _rootPath;

		private bool _secure;

		private WebSocketServiceManager _services;

		private ServerState _state;

		private object _sync;

		private bool _windows;

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

		public string RootPath
		{
			get
			{
				return null;
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

		public event EventHandler<HttpRequestEventArgs> OnConnect
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnDelete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnGet
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnHead
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnOptions
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnPatch
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnPost
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnPut
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<HttpRequestEventArgs> OnTrace
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public HttpServer()
		{
		}

		public HttpServer(int port)
		{
		}

		public HttpServer(string url)
		{
		}

		public HttpServer(int port, bool secure)
		{
		}

		public HttpServer(IPAddress address, int port)
		{
		}

		public HttpServer(IPAddress address, int port, bool secure)
		{
		}

		private void abort()
		{
		}

		private string checkIfCertificateExists()
		{
			return null;
		}

		private static string convertToString(IPAddress address)
		{
			return null;
		}

		private static string getHost(Uri uri)
		{
			return null;
		}

		private void init(string hostname, IPAddress address, int port, bool secure)
		{
		}

		private void processRequest(HttpListenerContext context)
		{
		}

		private void processRequest(HttpListenerWebSocketContext context)
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

		public byte[] GetFile(string path)
		{
			return null;
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
