using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace WebSocketSharp.Net.WebSockets
{
	internal class TcpListenerWebSocketContext : WebSocketContext
	{
		[CompilerGenerated]
		private sealed class _003Cget_SecWebSocketProtocols_003Ed__38 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public TcpListenerWebSocketContext _003C_003E4__this;

			private string[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
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
			public _003Cget_SecWebSocketProtocols_003Ed__38(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private CookieCollection _cookies;

		private Logger _logger;

		private NameValueCollection _queryString;

		private HttpRequest _request;

		private bool _secure;

		private Stream _stream;

		private TcpClient _tcpClient;

		private Uri _uri;

		private IPrincipal _user;

		private WebSocket _websocket;

		internal Logger Log => null;

		internal Stream Stream => null;

		public override CookieCollection CookieCollection => null;

		public override NameValueCollection Headers => null;

		public override string Host => null;

		public override bool IsAuthenticated => false;

		public override bool IsLocal => false;

		public override bool IsSecureConnection => false;

		public override bool IsWebSocketRequest => false;

		public override string Origin => null;

		public override NameValueCollection QueryString => null;

		public override Uri RequestUri => null;

		public override string SecWebSocketKey => null;

		public override IEnumerable<string> SecWebSocketProtocols
		{
			[IteratorStateMachine(typeof(_003Cget_SecWebSocketProtocols_003Ed__38))]
			get
			{
				return null;
			}
		}

		public override string SecWebSocketVersion => null;

		public override IPEndPoint ServerEndPoint => null;

		public override IPrincipal User => null;

		public override IPEndPoint UserEndPoint => null;

		public override WebSocket WebSocket => null;

		internal TcpListenerWebSocketContext(TcpClient tcpClient, string protocol, bool secure, ServerSslConfiguration sslConfig, Logger logger)
		{
		}

		internal bool Authenticate(AuthenticationSchemes scheme, string realm, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			return false;
		}

		internal void Close()
		{
		}

		internal void Close(HttpStatusCode code)
		{
		}

		internal void SendAuthenticationChallenge(string challenge)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
