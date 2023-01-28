using System;

public class Crypto
{
	public class AES
	{
		private static readonly string key;

		private static readonly byte[] keyArray;

		public static ArraySegment<byte> Encrypt(ArraySegment<byte> data)
		{
			return default(ArraySegment<byte>);
		}

		public static ArraySegment<byte> Decrypt(ArraySegment<byte> data)
		{
			return default(ArraySegment<byte>);
		}
	}

	public class XOR
	{
		private static bool isInit;

		private const int ENCRYPT_KEY_SIZE = 1024;

		private const string key = "n01e0m3o1e6k8h0e0l6l84c89bn54cf89jd1a36h0kpm7bfa4nv9q92p5c3n4548vnvkd63tdbxczmvklfu4623893jdnvgd62yhfb39fgnd63jvn373jfkuiq4da2p384vbdhf";

		private static byte[] keyByte;

		private static byte[] temp;

		private static void init()
		{
		}

		public static void Encrypt(byte[] src, int nStartIndex = 0)
		{
		}
	}
}
