using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Security.Principal;
using System.Text;

namespace WebSocketSharp.Net
{
	internal sealed class HttpUtility
	{
		private static Dictionary<string, char> _entities;

		private static char[] _hexChars;

		private static object _sync;

		private static int getChar(byte[] bytes, int offset, int length)
		{
			return 0;
		}

		private static int getChar(string s, int offset, int length)
		{
			return 0;
		}

		private static char[] getChars(MemoryStream buffer, Encoding encoding)
		{
			return null;
		}

		private static Dictionary<string, char> getEntities()
		{
			return null;
		}

		private static int getInt(byte b)
		{
			return 0;
		}

		private static void initEntities()
		{
		}

		private static bool notEncoded(char c)
		{
			return false;
		}

		private static void urlEncode(char c, Stream result, bool unicode)
		{
		}

		private static void urlPathEncode(char c, Stream result)
		{
		}

		private static void writeCharBytes(char c, IList buffer, Encoding encoding)
		{
		}

		internal static Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure)
		{
			return null;
		}

		internal static IPrincipal CreateUser(string response, AuthenticationSchemes scheme, string realm, string method, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			return null;
		}

		internal static Encoding GetEncoding(string contentType)
		{
			return null;
		}

		internal static NameValueCollection InternalParseQueryString(string query, Encoding encoding)
		{
			return null;
		}

		internal static string InternalUrlDecode(byte[] bytes, int offset, int count, Encoding encoding)
		{
			return null;
		}

		internal static byte[] InternalUrlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		internal static byte[] InternalUrlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		internal static byte[] InternalUrlEncodeUnicodeToBytes(string s)
		{
			return null;
		}

		public static string HtmlAttributeEncode(string s)
		{
			return null;
		}

		public static void HtmlAttributeEncode(string s, TextWriter output)
		{
		}

		public static string HtmlDecode(string s)
		{
			return null;
		}

		public static void HtmlDecode(string s, TextWriter output)
		{
		}

		public static string HtmlEncode(string s)
		{
			return null;
		}

		public static void HtmlEncode(string s, TextWriter output)
		{
		}

		public static NameValueCollection ParseQueryString(string query)
		{
			return null;
		}

		public static NameValueCollection ParseQueryString(string query, Encoding encoding)
		{
			return null;
		}

		public static string UrlDecode(string s)
		{
			return null;
		}

		public static string UrlDecode(string s, Encoding encoding)
		{
			return null;
		}

		public static string UrlDecode(byte[] bytes, Encoding encoding)
		{
			return null;
		}

		public static string UrlDecode(byte[] bytes, int offset, int count, Encoding encoding)
		{
			return null;
		}

		public static byte[] UrlDecodeToBytes(byte[] bytes)
		{
			return null;
		}

		public static byte[] UrlDecodeToBytes(string s)
		{
			return null;
		}

		public static byte[] UrlDecodeToBytes(string s, Encoding encoding)
		{
			return null;
		}

		public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		public static string UrlEncode(byte[] bytes)
		{
			return null;
		}

		public static string UrlEncode(string s)
		{
			return null;
		}

		public static string UrlEncode(string s, Encoding encoding)
		{
			return null;
		}

		public static string UrlEncode(byte[] bytes, int offset, int count)
		{
			return null;
		}

		public static byte[] UrlEncodeToBytes(byte[] bytes)
		{
			return null;
		}

		public static byte[] UrlEncodeToBytes(string s)
		{
			return null;
		}

		public static byte[] UrlEncodeToBytes(string s, Encoding encoding)
		{
			return null;
		}

		public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		public static string UrlEncodeUnicode(string s)
		{
			return null;
		}

		public static byte[] UrlEncodeUnicodeToBytes(string s)
		{
			return null;
		}

		public static string UrlPathEncode(string s)
		{
			return null;
		}
	}
}
