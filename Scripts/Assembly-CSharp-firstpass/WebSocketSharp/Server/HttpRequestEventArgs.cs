using System;
using WebSocketSharp.Net;

namespace WebSocketSharp.Server
{
	public class HttpRequestEventArgs : EventArgs
	{
		private HttpListenerRequest _request;

		private HttpListenerResponse _response;

		public HttpListenerRequest Request => null;

		public HttpListenerResponse Response => null;

		internal HttpRequestEventArgs(HttpListenerContext context)
		{
		}
	}
}
