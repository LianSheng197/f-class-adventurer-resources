using System.Collections.Generic;
using System.Text;

namespace WebSocketSharp.Net
{
	internal class ChunkStream
	{
		private int _chunkRead;

		private int _chunkSize;

		private List<Chunk> _chunks;

		private bool _gotIt;

		private WebHeaderCollection _headers;

		private StringBuilder _saved;

		private bool _sawCr;

		private InputChunkState _state;

		private int _trailerState;

		internal WebHeaderCollection Headers => null;

		public int ChunkLeft => 0;

		public bool WantMore => false;

		public ChunkStream(WebHeaderCollection headers)
		{
		}

		public ChunkStream(byte[] buffer, int offset, int count, WebHeaderCollection headers)
		{
		}

		private int read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		private static string removeChunkExtension(string value)
		{
			return null;
		}

		private InputChunkState seekCrLf(byte[] buffer, ref int offset, int length)
		{
			return default(InputChunkState);
		}

		private InputChunkState setChunkSize(byte[] buffer, ref int offset, int length)
		{
			return default(InputChunkState);
		}

		private InputChunkState setTrailer(byte[] buffer, ref int offset, int length)
		{
			return default(InputChunkState);
		}

		private static void throwProtocolViolation(string message)
		{
		}

		private void write(byte[] buffer, ref int offset, int length)
		{
		}

		private InputChunkState writeData(byte[] buffer, ref int offset, int length)
		{
			return default(InputChunkState);
		}

		internal void ResetBuffer()
		{
		}

		internal int WriteAndReadBack(byte[] buffer, int offset, int writeCount, int readCount)
		{
			return 0;
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
