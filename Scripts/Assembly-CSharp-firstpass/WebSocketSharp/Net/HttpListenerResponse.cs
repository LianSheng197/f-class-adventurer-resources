using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerResponse : IDisposable
	{
		[CompilerGenerated]
		private sealed class _003CfindCookie_003Ed__62 : IEnumerable<Cookie>, IEnumerable, IEnumerator<Cookie>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Cookie _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Cookie cookie;

			public Cookie _003C_003E3__cookie;

			public HttpListenerResponse _003C_003E4__this;

			private string _003Cname_003E5__2;

			private string _003Cdomain_003E5__3;

			private string _003Cpath_003E5__4;

			private IEnumerator _003C_003E7__wrap4;

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
			public _003CfindCookie_003Ed__62(int _003C_003E1__state)
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

		private bool _closeConnection;

		private Encoding _contentEncoding;

		private long _contentLength;

		private string _contentType;

		private HttpListenerContext _context;

		private CookieCollection _cookies;

		private bool _disposed;

		private WebHeaderCollection _headers;

		private bool _headersSent;

		private bool _keepAlive;

		private string _location;

		private ResponseStream _outputStream;

		private bool _sendChunked;

		private int _statusCode;

		private string _statusDescription;

		private Version _version;

		internal bool CloseConnection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool HeadersSent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Encoding ContentEncoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long ContentLength64
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string ContentType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CookieCollection Cookies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WebHeaderCollection Headers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool KeepAlive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Stream OutputStream => null;

		public Version ProtocolVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string RedirectLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SendChunked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int StatusCode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string StatusDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal HttpListenerResponse(HttpListenerContext context)
		{
		}

		private bool canAddOrUpdate(Cookie cookie)
		{
			return false;
		}

		private void checkDisposed()
		{
		}

		private void checkDisposedOrHeadersSent()
		{
		}

		private void close(bool force)
		{
		}

		[IteratorStateMachine(typeof(_003CfindCookie_003Ed__62))]
		private IEnumerable<Cookie> findCookie(Cookie cookie)
		{
			return null;
		}

		internal WebHeaderCollection WriteHeadersTo(MemoryStream destination)
		{
			return null;
		}

		public void Abort()
		{
		}

		public void AddHeader(string name, string value)
		{
		}

		public void AppendCookie(Cookie cookie)
		{
		}

		public void AppendHeader(string name, string value)
		{
		}

		public void Close()
		{
		}

		public void Close(byte[] responseEntity, bool willBlock)
		{
		}

		public void CopyFrom(HttpListenerResponse templateResponse)
		{
		}

		public void Redirect(string url)
		{
		}

		public void SetCookie(Cookie cookie)
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
