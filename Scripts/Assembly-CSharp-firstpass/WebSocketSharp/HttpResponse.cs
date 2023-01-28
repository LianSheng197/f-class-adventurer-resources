using System;
using System.Collections.Specialized;
using System.IO;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpResponse : HttpBase
	{
		private string _code;

		private string _reason;

		public CookieCollection Cookies => null;

		public bool HasConnectionClose => false;

		public bool IsProxyAuthenticationRequired => false;

		public bool IsRedirect => false;

		public bool IsUnauthorized => false;

		public bool IsWebSocketResponse => false;

		public string Reason => null;

		public string StatusCode => null;

		private HttpResponse(string code, string reason, Version version, NameValueCollection headers)
			: base(null, null)
		{
		}

		internal HttpResponse(HttpStatusCode code)
			: base(null, null)
		{
		}

		internal HttpResponse(HttpStatusCode code, string reason)
			: base(null, null)
		{
		}

		internal static HttpResponse CreateCloseResponse(HttpStatusCode code)
		{
			return null;
		}

		internal static HttpResponse CreateUnauthorizedResponse(string challenge)
		{
			return null;
		}

		internal static HttpResponse CreateWebSocketResponse()
		{
			return null;
		}

		internal static HttpResponse Parse(string[] headerParts)
		{
			return null;
		}

		internal static HttpResponse Read(Stream stream, int millisecondsTimeout)
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
