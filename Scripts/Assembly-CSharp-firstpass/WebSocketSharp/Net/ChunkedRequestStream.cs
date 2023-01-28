using System;
using System.IO;

namespace WebSocketSharp.Net
{
	internal class ChunkedRequestStream : RequestStream
	{
		private const int _bufferLength = 8192;

		private HttpListenerContext _context;

		private ChunkStream _decoder;

		private bool _disposed;

		private bool _noMoreData;

		internal ChunkStream Decoder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ChunkedRequestStream(Stream stream, byte[] buffer, int offset, int count, HttpListenerContext context)
			: base(null, null, 0, 0)
		{
		}

		private void onRead(IAsyncResult asyncResult)
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void Close()
		{
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}
	}
}
