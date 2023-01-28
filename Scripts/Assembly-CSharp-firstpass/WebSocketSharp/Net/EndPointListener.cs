using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	internal sealed class EndPointListener
	{
		private List<HttpListenerPrefix> _all;

		private static readonly string _defaultCertFolderPath;

		private IPEndPoint _endpoint;

		private Dictionary<HttpListenerPrefix, HttpListener> _prefixes;

		private bool _secure;

		private Socket _socket;

		private ServerSslConfiguration _sslConfig;

		private List<HttpListenerPrefix> _unhandled;

		private Dictionary<HttpConnection, HttpConnection> _unregistered;

		private object _unregisteredSync;

		public IPAddress Address => null;

		public bool IsSecure => false;

		public int Port => 0;

		public ServerSslConfiguration SslConfiguration => null;

		static EndPointListener()
		{
		}

		internal EndPointListener(IPEndPoint endpoint, bool secure, string certificateFolderPath, ServerSslConfiguration sslConfig, bool reuseAddress)
		{
		}

		private static void addSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix)
		{
		}

		private static RSACryptoServiceProvider createRSAFromFile(string filename)
		{
			return null;
		}

		private static X509Certificate2 getCertificate(int port, string folderPath, X509Certificate2 defaultCertificate)
		{
			return null;
		}

		private void leaveIfNoPrefix()
		{
		}

		private static void onAccept(IAsyncResult asyncResult)
		{
		}

		private static void processAccepted(Socket socket, EndPointListener listener)
		{
		}

		private static bool removeSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix)
		{
			return false;
		}

		private static HttpListener searchHttpListenerFromSpecial(string path, List<HttpListenerPrefix> prefixes)
		{
			return null;
		}

		internal static bool CertificateExists(int port, string folderPath)
		{
			return false;
		}

		internal void RemoveConnection(HttpConnection connection)
		{
		}

		internal bool TrySearchHttpListener(Uri uri, out HttpListener listener)
		{
			listener = null;
			return false;
		}

		public void AddPrefix(HttpListenerPrefix prefix, HttpListener listener)
		{
		}

		public void Close()
		{
		}

		public void RemovePrefix(HttpListenerPrefix prefix, HttpListener listener)
		{
		}
	}
}
