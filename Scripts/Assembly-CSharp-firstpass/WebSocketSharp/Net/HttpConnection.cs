using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal sealed class HttpConnection
	{
		private byte[] _buffer;

		private const int _bufferLength = 8192;

		private HttpListenerContext _context;

		private bool _contextRegistered;

		private StringBuilder _currentLine;

		private InputState _inputState;

		private RequestStream _inputStream;

		private HttpListener _lastListener;

		private LineState _lineState;

		private EndPointListener _listener;

		private ResponseStream _outputStream;

		private int _position;

		private MemoryStream _requestBuffer;

		private int _reuses;

		private bool _secure;

		private Socket _socket;

		private Stream _stream;

		private object _sync;

		private int _timeout;

		private Dictionary<int, bool> _timeoutCanceled;

		private Timer _timer;

		public bool IsClosed => false;

		public bool IsSecure => false;

		public IPEndPoint LocalEndPoint => null;

		public IPEndPoint RemoteEndPoint => null;

		public int Reuses => 0;

		public Stream Stream => null;

		internal HttpConnection(Socket socket, EndPointListener listener)
		{
		}

		private void close()
		{
		}

		private void closeSocket()
		{
		}

		private void disposeRequestBuffer()
		{
		}

		private void disposeStream()
		{
		}

		private void disposeTimer()
		{
		}

		private void init()
		{
		}

		private static void onRead(IAsyncResult asyncResult)
		{
		}

		private static void onTimeout(object state)
		{
		}

		private bool processInput(byte[] data, int length)
		{
			return false;
		}

		private string readLineFrom(byte[] buffer, int offset, int length, out int read)
		{
			read = default(int);
			return null;
		}

		private void removeConnection()
		{
		}

		private void unregisterContext()
		{
		}

		internal void Close(bool force)
		{
		}

		public void BeginReadRequest()
		{
		}

		public void Close()
		{
		}

		public RequestStream GetRequestStream(long contentLength, bool chunked)
		{
			return null;
		}

		public ResponseStream GetResponseStream()
		{
			return null;
		}

		public void SendError()
		{
		}

		public void SendError(string message, int status)
		{
		}
	}
}
