using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp
{
	public class WebSocket : IDisposable
	{
		[CompilerGenerated]
		private sealed class _003Cget_Cookies_003Ed__67 : IEnumerable<Cookie>, IEnumerable, IEnumerator<Cookie>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Cookie _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public WebSocket _003C_003E4__this;

			private object _003C_003E7__wrap1;

			private bool _003C_003E7__wrap2;

			private IEnumerator _003C_003E7__wrap3;

			private Cookie System_002ECollections_002EGeneric_002EIEnumerator_003CWebSocketSharp_002ENet_002ECookie_003E_002ECurrent
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
			public _003Cget_Cookies_003Ed__67(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Cookie> System_002ECollections_002EGeneric_002EIEnumerable_003CWebSocketSharp_002ENet_002ECookie_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private AuthenticationChallenge _authChallenge;

		private string _base64Key;

		private bool _client;

		private Action _closeContext;

		private CompressionMethod _compression;

		private WebSocketContext _context;

		private CookieCollection _cookies;

		private NetworkCredential _credentials;

		private bool _emitOnPing;

		private bool _enableRedirection;

		private AutoResetEvent _exitReceiving;

		private string _extensions;

		private bool _extensionsRequested;

		private object _forConn;

		private object _forMessageEventQueue;

		private object _forSend;

		private MemoryStream _fragmentsBuffer;

		private bool _fragmentsCompressed;

		private Opcode _fragmentsOpcode;

		private const string _guid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

		private Func<WebSocketContext, string> _handshakeRequestChecker;

		private bool _ignoreExtensions;

		private bool _inContinuation;

		private bool _inMessage;

		private Logger _logger;

		private Action<MessageEventArgs> _message;

		private Queue<MessageEventArgs> _messageEventQueue;

		private uint _nonceCount;

		private string _origin;

		private bool _preAuth;

		private string _protocol;

		private string[] _protocols;

		private bool _protocolsRequested;

		private NetworkCredential _proxyCredentials;

		private Uri _proxyUri;

		private WebSocketState _readyState;

		private AutoResetEvent _receivePong;

		private bool _secure;

		private ClientSslConfiguration _sslConfig;

		private Stream _stream;

		private TcpClient _tcpClient;

		private Uri _uri;

		private const string _version = "13";

		private TimeSpan _waitTime;

		internal static readonly byte[] EmptyBytes;

		internal static readonly int FragmentLength;

		internal static readonly RandomNumberGenerator RandomNumber;

		internal CookieCollection CookieCollection => null;

		internal Func<WebSocketContext, string> CustomHandshakeRequestChecker
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool HasMessage => false;

		internal bool IgnoreExtensions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsConnected => false;

		public CompressionMethod Compression
		{
			get
			{
				return default(CompressionMethod);
			}
			set
			{
			}
		}

		public IEnumerable<Cookie> Cookies
		{
			[IteratorStateMachine(typeof(_003Cget_Cookies_003Ed__67))]
			get
			{
				return null;
			}
		}

		public NetworkCredential Credentials => null;

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

		public bool EnableRedirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Extensions => null;

		public bool IsAlive => false;

		public bool IsSecure => false;

		public Logger Log
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Origin
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
			internal set
			{
			}
		}

		public WebSocketState ReadyState => default(WebSocketState);

		public ClientSslConfiguration SslConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Uri Url => null;

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

		public event EventHandler<CloseEventArgs> OnClose
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

		public event EventHandler<ErrorEventArgs> OnError
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

		public event EventHandler<MessageEventArgs> OnMessage
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

		public event EventHandler OnOpen
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

		static WebSocket()
		{
		}

		internal WebSocket(HttpListenerWebSocketContext context, string protocol)
		{
		}

		internal WebSocket(TcpListenerWebSocketContext context, string protocol)
		{
		}

		public WebSocket(string url, params string[] protocols)
		{
		}

		private bool accept()
		{
			return false;
		}

		private bool acceptHandshake()
		{
			return false;
		}

		private bool checkHandshakeRequest(WebSocketContext context, out string message)
		{
			message = null;
			return false;
		}

		private bool checkHandshakeResponse(HttpResponse response, out string message)
		{
			message = null;
			return false;
		}

		private bool checkIfAvailable(bool connecting, bool open, bool closing, bool closed, out string message)
		{
			message = null;
			return false;
		}

		private bool checkIfAvailable(bool client, bool server, bool connecting, bool open, bool closing, bool closed, out string message)
		{
			message = null;
			return false;
		}

		private bool checkReceivedFrame(WebSocketFrame frame, out string message)
		{
			message = null;
			return false;
		}

		private void close(CloseEventArgs e, bool send, bool receive, bool received)
		{
		}

		private void closeAsync(CloseEventArgs e, bool send, bool receive, bool received)
		{
		}

		private bool closeHandshake(byte[] frameAsBytes, bool receive, bool received)
		{
			return false;
		}

		private bool connect()
		{
			return false;
		}

		private string createExtensions()
		{
			return null;
		}

		private HttpResponse createHandshakeFailureResponse(HttpStatusCode code)
		{
			return null;
		}

		private HttpRequest createHandshakeRequest()
		{
			return null;
		}

		private HttpResponse createHandshakeResponse()
		{
			return null;
		}

		private bool customCheckHandshakeRequest(WebSocketContext context, out string message)
		{
			message = null;
			return false;
		}

		private MessageEventArgs dequeueFromMessageEventQueue()
		{
			return null;
		}

		private bool doHandshake()
		{
			return false;
		}

		private void enqueueToMessageEventQueue(MessageEventArgs e)
		{
		}

		private void error(string message, Exception exception)
		{
		}

		private void fatal(string message, Exception exception)
		{
		}

		private void fatal(string message, CloseStatusCode code)
		{
		}

		private void init()
		{
		}

		private void message()
		{
		}

		private void messagec(MessageEventArgs e)
		{
		}

		private void messages(MessageEventArgs e)
		{
		}

		private void open()
		{
		}

		private bool processCloseFrame(WebSocketFrame frame)
		{
			return false;
		}

		private void processCookies(CookieCollection cookies)
		{
		}

		private bool processDataFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processFragmentFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processPingFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processPongFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processReceivedFrame(WebSocketFrame frame)
		{
			return false;
		}

		private void processSecWebSocketExtensionsClientHeader(string value)
		{
		}

		private void processSecWebSocketExtensionsServerHeader(string value)
		{
		}

		private void processSecWebSocketProtocolHeader(IEnumerable<string> values)
		{
		}

		private bool processUnsupportedFrame(WebSocketFrame frame)
		{
			return false;
		}

		private void releaseClientResources()
		{
		}

		private void releaseCommonResources()
		{
		}

		private void releaseResources()
		{
		}

		private void releaseServerResources()
		{
		}

		private bool send(byte[] frameAsBytes)
		{
			return false;
		}

		private bool send(Opcode opcode, Stream stream)
		{
			return false;
		}

		private bool send(Opcode opcode, Stream stream, bool compressed)
		{
			return false;
		}

		private bool send(Fin fin, Opcode opcode, byte[] data, bool compressed)
		{
			return false;
		}

		private void sendAsync(Opcode opcode, Stream stream, Action<bool> completed)
		{
		}

		private bool sendBytes(byte[] bytes)
		{
			return false;
		}

		private HttpResponse sendHandshakeRequest()
		{
			return null;
		}

		private HttpResponse sendHttpRequest(HttpRequest request, int millisecondsTimeout)
		{
			return null;
		}

		private bool sendHttpResponse(HttpResponse response)
		{
			return false;
		}

		private void sendProxyConnectRequest()
		{
		}

		private void setClientStream()
		{
		}

		private void startReceiving()
		{
		}

		private bool validateSecWebSocketAcceptHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketExtensionsClientHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketExtensionsServerHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketKeyHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketProtocolClientHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketProtocolServerHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketVersionClientHeader(string value)
		{
			return false;
		}

		private bool validateSecWebSocketVersionServerHeader(string value)
		{
			return false;
		}

		internal static string CheckCloseParameters(ushort code, string reason, bool client)
		{
			return null;
		}

		internal static string CheckCloseParameters(CloseStatusCode code, string reason, bool client)
		{
			return null;
		}

		internal static string CheckPingParameter(string message, out byte[] bytes)
		{
			bytes = null;
			return null;
		}

		internal static string CheckSendParameter(byte[] data)
		{
			return null;
		}

		internal static string CheckSendParameter(FileInfo file)
		{
			return null;
		}

		internal static string CheckSendParameter(string data)
		{
			return null;
		}

		internal static string CheckSendParameters(Stream stream, int length)
		{
			return null;
		}

		internal void Close(HttpResponse response)
		{
		}

		internal void Close(HttpStatusCode code)
		{
		}

		internal void Close(CloseEventArgs e, byte[] frameAsBytes, bool receive)
		{
		}

		internal static string CreateBase64Key()
		{
			return null;
		}

		internal static string CreateResponseKey(string base64Key)
		{
			return null;
		}

		internal void InternalAccept()
		{
		}

		internal bool Ping(byte[] frameAsBytes, TimeSpan timeout)
		{
			return false;
		}

		internal void Send(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache)
		{
		}

		internal void Send(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache)
		{
		}

		public void Accept()
		{
		}

		public void AcceptAsync()
		{
		}

		public void Close()
		{
		}

		public void Close(ushort code)
		{
		}

		public void Close(CloseStatusCode code)
		{
		}

		public void Close(ushort code, string reason)
		{
		}

		public void Close(CloseStatusCode code, string reason)
		{
		}

		public void CloseAsync()
		{
		}

		public void CloseAsync(ushort code)
		{
		}

		public void CloseAsync(CloseStatusCode code)
		{
		}

		public void CloseAsync(ushort code, string reason)
		{
		}

		public void CloseAsync(CloseStatusCode code, string reason)
		{
		}

		public void Connect()
		{
		}

		public void ConnectAsync()
		{
		}

		public bool Ping()
		{
			return false;
		}

		public bool Ping(string message)
		{
			return false;
		}

		public void Send(byte[] data)
		{
		}

		public void Send(FileInfo file)
		{
		}

		public void Send(string data)
		{
		}

		public void SendAsync(byte[] data, Action<bool> completed)
		{
		}

		public void SendAsync(FileInfo file, Action<bool> completed)
		{
		}

		public void SendAsync(string data, Action<bool> completed)
		{
		}

		public void SendAsync(Stream stream, int length, Action<bool> completed)
		{
		}

		public void SetCookie(Cookie cookie)
		{
		}

		public void SetCredentials(string username, string password, bool preAuth)
		{
		}

		public void SetProxy(string url, string username, string password)
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
