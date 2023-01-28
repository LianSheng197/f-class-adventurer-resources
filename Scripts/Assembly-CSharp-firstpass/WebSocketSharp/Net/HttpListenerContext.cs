using System.Security.Principal;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerContext
	{
		private HttpConnection _connection;

		private string _error;

		private int _errorStatus;

		private HttpListener _listener;

		private HttpListenerRequest _request;

		private HttpListenerResponse _response;

		private IPrincipal _user;

		private HttpListenerWebSocketContext _websocketContext;

		internal HttpConnection Connection => null;

		internal string ErrorMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int ErrorStatus
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool HasError => false;

		internal HttpListener Listener
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HttpListenerRequest Request => null;

		public HttpListenerResponse Response => null;

		public IPrincipal User => null;

		internal HttpListenerContext(HttpConnection connection)
		{
		}

		internal bool Authenticate()
		{
			return false;
		}

		internal bool Register()
		{
			return false;
		}

		internal void Unregister()
		{
		}

		public HttpListenerWebSocketContext AcceptWebSocket(string protocol)
		{
			return null;
		}
	}
}
