using System;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace ekgames
{
	public static class MessageHelper
	{
		public struct Message
		{
			public bool enableCompression
			{
				[CompilerGenerated]
				readonly get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public JObject data
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private static readonly int HeaderSize;

		public static ArraySegment<byte> MakeMessage(string message, bool enableCompression, bool enableEncryption)
		{
			return default(ArraySegment<byte>);
		}

		public static Message GetMessage(ArraySegment<byte> messageBytes, bool enableEncrypt)
		{
			return default(Message);
		}

		public static Message GetMessage(Stream stream, bool enableEncrypt)
		{
			return default(Message);
		}
	}
}
