using System.IO;

namespace CodeStage.AntiCheat.Storage
{
	internal static class ObscuredFileCrypto
	{
		private const int HashSize = 4;

		private const int BufferSize = 81920;

		private static byte[] copyStreamBuffer;

		public static void Encrypt(Stream input, Stream output, EncryptionSettings settings)
		{
		}

		public static void Decrypt(Stream input, Stream output, EncryptionSettings settings)
		{
		}

		internal static uint CalculateHash(Stream input)
		{
			return 0u;
		}

		internal static uint ReadHash(Stream input)
		{
			return 0u;
		}

		internal static void WriteHash(Stream writer, uint hash)
		{
		}

		private static uint CalculateHashInternal(Stream input)
		{
			return 0u;
		}

		private static void EncryptInternal(Stream input, Stream output, EncryptionSettings settings)
		{
		}

		private static byte[] HashToBytes(uint hash)
		{
			return null;
		}

		private static uint BytesToHash(byte[] hash)
		{
			return 0u;
		}

		private static void DecryptInternal(Stream input, Stream output, EncryptionSettings settings)
		{
		}
	}
}
