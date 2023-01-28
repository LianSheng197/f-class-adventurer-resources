using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;
using WebSocketSharp.Server;

namespace WebSocketSharp
{
	public static class Ext
	{
		[CompilerGenerated]
		private sealed class _003CSplitHeaderValue_003Ed__58 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private string value;

			public string _003C_003E3__value;

			private char[] separators;

			public char[] _003C_003E3__separators;

			private int _003Clen_003E5__2;

			private string _003Cseps_003E5__3;

			private StringBuilder _003Cbuff_003E5__4;

			private bool _003Cescaped_003E5__5;

			private bool _003Cquoted_003E5__6;

			private int _003Ci_003E5__7;

			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSplitHeaderValue_003Ed__58(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private static readonly byte[] _last;

		private static readonly int _retry;

		private const string _tspecials = "()<>@,;:\\\"/[]?={} \t";

		private static byte[] compress(this byte[] data)
		{
			return null;
		}

		private static MemoryStream compress(this Stream stream)
		{
			return null;
		}

		private static byte[] compressToArray(this Stream stream)
		{
			return null;
		}

		private static byte[] decompress(this byte[] data)
		{
			return null;
		}

		private static MemoryStream decompress(this Stream stream)
		{
			return null;
		}

		private static byte[] decompressToArray(this Stream stream)
		{
			return null;
		}

		private static void times(this ulong n, Action action)
		{
		}

		internal static byte[] Append(this ushort code, string reason)
		{
			return null;
		}

		internal static string CheckIfAvailable(this ServerState state, bool ready, bool start, bool shutting)
		{
			return null;
		}

		internal static string CheckIfAvailable(this WebSocketState state, bool connecting, bool open, bool closing, bool closed)
		{
			return null;
		}

		internal static string CheckIfValidProtocols(this string[] protocols)
		{
			return null;
		}

		internal static string CheckIfValidServicePath(this string path)
		{
			return null;
		}

		internal static string CheckIfValidSessionID(this string id)
		{
			return null;
		}

		internal static string CheckIfValidWaitTime(this TimeSpan time)
		{
			return null;
		}

		internal static bool CheckWaitTime(this TimeSpan time, out string message)
		{
			message = null;
			return false;
		}

		internal static void Close(this HttpListenerResponse response, WebSocketSharp.Net.HttpStatusCode code)
		{
		}

		internal static void CloseWithAuthChallenge(this HttpListenerResponse response, string challenge)
		{
		}

		internal static byte[] Compress(this byte[] data, CompressionMethod method)
		{
			return null;
		}

		internal static Stream Compress(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static byte[] CompressToArray(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition)
		{
			return false;
		}

		internal static bool ContainsTwice(this string[] values)
		{
			return false;
		}

		internal static T[] Copy<T>(this T[] source, long length)
		{
			return null;
		}

		internal static void CopyTo(this Stream source, Stream destination, int bufferLength)
		{
		}

		internal static void CopyToAsync(this Stream source, Stream destination, int bufferLength, Action completed, Action<Exception> error)
		{
		}

		internal static byte[] Decompress(this byte[] data, CompressionMethod method)
		{
			return null;
		}

		internal static Stream Decompress(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static bool EqualsWith(this int value, char c, Action<int> action)
		{
			return false;
		}

		internal static string GetAbsolutePath(this Uri uri)
		{
			return null;
		}

		internal static string GetMessage(this CloseStatusCode code)
		{
			return null;
		}

		internal static string GetName(this string nameAndValue, char separator)
		{
			return null;
		}

		internal static string GetValue(this string nameAndValue, char separator)
		{
			return null;
		}

		internal static string GetValue(this string nameAndValue, char separator, bool unquote)
		{
			return null;
		}

		internal static TcpListenerWebSocketContext GetWebSocketContext(this TcpClient tcpClient, string protocol, bool secure, ServerSslConfiguration sslConfig, Logger logger)
		{
			return null;
		}

		internal static byte[] InternalToByteArray(this ushort value, ByteOrder order)
		{
			return null;
		}

		internal static byte[] InternalToByteArray(this ulong value, ByteOrder order)
		{
			return null;
		}

		internal static bool IsCompressionExtension(this string value, CompressionMethod method)
		{
			return false;
		}

		internal static bool IsControl(this byte opcode)
		{
			return false;
		}

		internal static bool IsControl(this Opcode opcode)
		{
			return false;
		}

		internal static bool IsData(this byte opcode)
		{
			return false;
		}

		internal static bool IsData(this Opcode opcode)
		{
			return false;
		}

		internal static bool IsPortNumber(this int value)
		{
			return false;
		}

		internal static bool IsReserved(this ushort code)
		{
			return false;
		}

		internal static bool IsReserved(this CloseStatusCode code)
		{
			return false;
		}

		internal static bool IsSupported(this byte opcode)
		{
			return false;
		}

		internal static bool IsText(this string value)
		{
			return false;
		}

		internal static bool IsToken(this string value)
		{
			return false;
		}

		internal static string Quote(this string value)
		{
			return null;
		}

		internal static byte[] ReadBytes(this Stream stream, int length)
		{
			return null;
		}

		internal static byte[] ReadBytes(this Stream stream, long length, int bufferLength)
		{
			return null;
		}

		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static string RemovePrefix(this string value, params string[] prefixes)
		{
			return null;
		}

		internal static T[] Reverse<T>(this T[] array)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSplitHeaderValue_003Ed__58))]
		internal static IEnumerable<string> SplitHeaderValue(this string value, params char[] separators)
		{
			return null;
		}

		internal static byte[] ToByteArray(this Stream stream)
		{
			return null;
		}

		internal static CompressionMethod ToCompressionMethod(this string value)
		{
			return default(CompressionMethod);
		}

		internal static string ToExtensionString(this CompressionMethod method, params string[] parameters)
		{
			return null;
		}

		internal static IPAddress ToIPAddress(this string hostnameOrAddress)
		{
			return null;
		}

		internal static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder)
		{
			return 0;
		}

		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder)
		{
			return 0uL;
		}

		internal static string TrimEndSlash(this string value)
		{
			return null;
		}

		internal static bool TryCreateWebSocketUri(this string uriString, out Uri result, out string message)
		{
			result = null;
			message = null;
			return false;
		}

		internal static string Unquote(this string value)
		{
			return null;
		}

		internal static string UTF8Decode(this byte[] bytes)
		{
			return null;
		}

		internal static byte[] UTF8Encode(this string s)
		{
			return null;
		}

		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength)
		{
		}

		internal static void WriteBytesAsync(this Stream stream, byte[] bytes, int bufferLength, Action completed, Action<Exception> error)
		{
		}

		public static bool Contains(this string value, params char[] chars)
		{
			return false;
		}

		public static bool Contains(this NameValueCollection collection, string name)
		{
			return false;
		}

		public static bool Contains(this NameValueCollection collection, string name, string value)
		{
			return false;
		}

		public static void Emit(this EventHandler eventHandler, object sender, EventArgs e)
		{
		}

		public static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
		}

		public static WebSocketSharp.Net.CookieCollection GetCookies(this NameValueCollection headers, bool response)
		{
			return null;
		}

		public static string GetDescription(this WebSocketSharp.Net.HttpStatusCode code)
		{
			return null;
		}

		public static string GetStatusDescription(this int code)
		{
			return null;
		}

		public static bool IsCloseStatusCode(this ushort value)
		{
			return false;
		}

		public static bool IsEnclosedIn(this string value, char c)
		{
			return false;
		}

		public static bool IsHostOrder(this ByteOrder order)
		{
			return false;
		}

		public static bool IsLocal(this IPAddress address)
		{
			return false;
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return false;
		}

		public static bool IsPredefinedScheme(this string value)
		{
			return false;
		}

		public static bool IsUpgradeTo(this HttpListenerRequest request, string protocol)
		{
			return false;
		}

		public static bool MaybeUri(this string value)
		{
			return false;
		}

		public static T[] SubArray<T>(this T[] array, int startIndex, int length)
		{
			return null;
		}

		public static T[] SubArray<T>(this T[] array, long startIndex, long length)
		{
			return null;
		}

		public static void Times(this int n, Action action)
		{
		}

		public static void Times(this long n, Action action)
		{
		}

		public static void Times(this uint n, Action action)
		{
		}

		public static void Times(this ulong n, Action action)
		{
		}

		public static void Times(this int n, Action<int> action)
		{
		}

		public static void Times(this long n, Action<long> action)
		{
		}

		public static void Times(this uint n, Action<uint> action)
		{
		}

		public static void Times(this ulong n, Action<ulong> action)
		{
		}

		public static T To<T>(this byte[] source, ByteOrder sourceOrder) where T : struct
		{
			return default(T);
		}

		public static byte[] ToByteArray<T>(this T value, ByteOrder order) where T : struct
		{
			return null;
		}

		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder)
		{
			return null;
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			return null;
		}

		public static Uri ToUri(this string uriString)
		{
			return null;
		}

		public static string UrlDecode(this string value)
		{
			return null;
		}

		public static string UrlEncode(this string value)
		{
			return null;
		}

		public static void WriteContent(this HttpListenerResponse response, byte[] content)
		{
		}
	}
}
