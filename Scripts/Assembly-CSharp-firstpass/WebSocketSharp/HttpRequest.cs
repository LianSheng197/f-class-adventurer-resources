using System;
using System.Collections.Specialized;
using System.IO;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpRequest : HttpBase
	{
		private string _method;

		private string _uri;

		private bool _websocketRequest;

		private bool _websocketRequestSet;

		public AuthenticationResponse AuthenticationResponse => null;

		public CookieCollection Cookies => null;

		public string HttpMethod => null;

		public bool IsWebSocketRequest => false;

		public string RequestUri => null;

		private HttpRequest(string method, string uri, Version version, NameValueCollection headers)
			: base(null, null)
		{
		}

		internal HttpRequest(string method, string uri)
			: base(null, null)
		{
		}

		internal static HttpRequest CreateConnectRequest(Uri uri)
		{
			return null;
		}

		internal static HttpRequest CreateWebSocketRequest(Uri uri)
		{
			return null;
		}

		internal HttpResponse GetResponse(Stream stream, int millisecondsTimeout)
		{
			return null;
		}

		internal static HttpRequest Parse(string[] headerParts)
		{
			return null;
		}

		internal static HttpRequest Read(Stream stream, int millisecondsTimeout)
		{
			return null;
		}

		public void SetCookies(CookieCollection cookies)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
