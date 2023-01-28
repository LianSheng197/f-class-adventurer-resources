using System;
using System.IO;

namespace WebSocketSharp.Net
{
	internal class RequestStream : Stream
	{
		private long _bodyLeft;

		private byte[] _buffer;

		private int _count;

		private bool _disposed;

		private int _offset;

		private Stream _stream;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal RequestStream(Stream stream, byte[] buffer, int offset, int count)
		{
		}

		internal RequestStream(Stream stream, byte[] buffer, int offset, int count, long contentLength)
		{
		}

		private int fillFromBuffer(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
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

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
