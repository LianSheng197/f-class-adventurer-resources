using System.IO;
using System.Security.Cryptography;

namespace CodeStage.AntiCheat.Utils
{
	internal static class CryptoUtils
	{
		private const int BufferSize = 81920;

		private const byte Iterations = 10;

		private const byte AesSaltLengthBytes = 16;

		private const byte AesKeyLengthBytes = 16;

		private const byte Rc2SaltLengthBytes = 8;

		private const byte Rc2KeyLengthBytes = 7;

		public static void EncryptAes(Stream input, Stream output, byte[] password)
		{
		}

		public static void DecryptAes(Stream input, Stream output, byte[] password)
		{
		}

		public static void EncryptRc2(Stream input, Stream output, byte[] password)
		{
		}

		public static void DecryptRc2(Stream input, Stream output, byte[] password)
		{
		}

		private static void EncryptInternal<T>(Stream input, Stream output, byte[] password, byte keyLength) where T : SymmetricAlgorithm, new()
		{
		}

		private static void DecryptInternal<T>(Stream input, Stream output, byte[] password, byte keyLength, byte saltLength) where T : SymmetricAlgorithm, new()
		{
		}
	}
}
