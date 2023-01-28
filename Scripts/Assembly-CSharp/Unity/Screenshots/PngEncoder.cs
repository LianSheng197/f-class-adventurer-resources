using System;
using System.Collections.Generic;

namespace Unity.Screenshots
{
	public static class PngEncoder
	{
		public class Crc32
		{
			private static uint generator;

			private readonly uint[] checksumTable;

			public uint Calculate<T>(IEnumerable<T> byteStream)
			{
				return 0u;
			}
		}

		private static Crc32 crc32;

		static PngEncoder()
		{
		}

		private static uint Adler32(byte[] bytes)
		{
			return 0u;
		}

		private static void AppendByte(this byte[] data, ref int position, byte value)
		{
		}

		private static void AppendBytes(this byte[] data, ref int position, byte[] value)
		{
		}

		private static void AppendChunk(this byte[] data, ref int position, string chunkType, byte[] chunkData)
		{
		}

		private static void AppendInt(this byte[] data, ref int position, int value)
		{
		}

		private static void AppendUInt(this byte[] data, ref int position, uint value)
		{
		}

		private static byte[] Compress(byte[] bytes)
		{
			return null;
		}

		public static byte[] Encode(byte[] dataRgba, int stride)
		{
			return null;
		}

		public static void EncodeAsync(byte[] dataRgba, int stride, Action<Exception, byte[]> callback)
		{
		}

		private static uint GetChunkCrc(byte[] chunkTypeBytes, byte[] chunkData)
		{
			return 0u;
		}

		private static byte[] GetChunkTypeBytes(string value)
		{
			return null;
		}
	}
}
