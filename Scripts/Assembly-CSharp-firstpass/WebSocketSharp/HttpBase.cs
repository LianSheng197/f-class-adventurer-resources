using System;
using System.Collections.Specialized;
using System.IO;

namespace WebSocketSharp
{
	internal abstract class HttpBase
	{
		private NameValueCollection _headers;

		private const int _headersMaxLength = 8192;

		private Version _version;

		internal byte[] EntityBodyData;

		protected const string CrLf = "\r\n";

		public string EntityBody => null;

		public NameValueCollection Headers => null;

		public Version ProtocolVersion => null;

		protected HttpBase(Version version, NameValueCollection headers)
		{
		}

		private static byte[] readEntityBody(Stream stream, string length)
		{
			return null;
		}

		private static string[] readHeaders(Stream stream, int maxLength)
		{
			return null;
		}

		protected static T Read<T>(Stream stream, Func<string[], T> parser, int millisecondsTimeout) where T : HttpBase
		{
			return null;
		}

		public byte[] ToByteArray()
		{
			return null;
		}
	}
}
