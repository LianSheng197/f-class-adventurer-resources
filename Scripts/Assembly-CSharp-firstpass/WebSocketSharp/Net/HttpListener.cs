using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public sealed class HttpListener : IDisposable
	{
		private AuthenticationSchemes _authSchemes;

		private Func<HttpListenerRequest, AuthenticationSchemes> _authSchemeSelector;

		private string _certFolderPath;

		private Dictionary<HttpConnection, HttpConnection> _connections;

		private object _connectionsSync;

		private List<HttpListenerContext> _ctxQueue;

		private object _ctxQueueSync;

		private Dictionary<HttpListenerContext, HttpListenerContext> _ctxRegistry;

		private object _ctxRegistrySync;

		private static readonly string _defaultRealm;

		private bool _disposed;

		private bool _ignoreWriteExceptions;

		private bool _listening;

		private Logger _logger;

		private HttpListenerPrefixCollection _prefixes;

		private string _realm;

		private bool _reuseAddress;

		private ServerSslConfiguration _sslConfig;

		private Func<IIdentity, NetworkCredential> _userCredFinder;

		private List<HttpListenerAsyncResult> _waitQueue;

		private object _waitQueueSync;

		internal bool IsDisposed => false;

		internal bool ReuseAddress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public Func<HttpListenerRequest, AuthenticationSchemes> AuthenticationSchemeSelector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CertificateFolderPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IgnoreWriteExceptions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsListening => false;

		public static bool IsSupported => false;

		public Logger Log => null;

		public HttpListenerPrefixCollection Prefixes => null;

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

		public bool UnsafeConnectionNtlmAuthentication
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Func<IIdentity, NetworkCredential> UserCredentialsFinder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static HttpListener()
		{
		}

		private void cleanupConnections()
		{
		}

		private void cleanupContextQueue(bool sendServiceUnavailable)
		{
		}

		private void cleanupContextRegistry()
		{
		}

		private void cleanupWaitQueue(Exception exception)
		{
		}

		private void close(bool force)
		{
		}

		private HttpListenerAsyncResult getAsyncResultFromQueue()
		{
			return null;
		}

		private HttpListenerContext getContextFromQueue()
		{
			return null;
		}

		internal bool AddConnection(HttpConnection connection)
		{
			return false;
		}

		internal HttpListenerAsyncResult BeginGetContext(HttpListenerAsyncResult asyncResult)
		{
			return null;
		}

		internal void CheckDisposed()
		{
		}

		internal string GetRealm()
		{
			return null;
		}

		internal Func<IIdentity, NetworkCredential> GetUserCredentialsFinder()
		{
			return null;
		}

		internal bool RegisterContext(HttpListenerContext context)
		{
			return false;
		}

		internal void RemoveConnection(HttpConnection connection)
		{
		}

		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerRequest request)
		{
			return default(AuthenticationSchemes);
		}

		internal void UnregisterContext(HttpListenerContext context)
		{
		}

		public void Abort()
		{
		}

		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			return null;
		}

		public void Close()
		{
		}

		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			return null;
		}

		public HttpListenerContext GetContext()
		{
			return null;
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
