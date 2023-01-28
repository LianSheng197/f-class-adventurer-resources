using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WebSocketSharp.Net
{
	[Serializable]
	[ComVisible(true)]
	[DefaultMember("Item")]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private static readonly Dictionary<string, HttpHeaderInfo> _headers;

		private bool _internallyUsed;

		private HttpHeaderType _state;

		internal HttpHeaderType State => default(HttpHeaderType);

		public override string[] AllKeys => null;

		public override int Count => 0;

		public new string Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new string Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override KeysCollection Keys => null;

		static WebHeaderCollection()
		{
		}

		internal WebHeaderCollection(HttpHeaderType state, bool internallyUsed)
		{
		}

		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public WebHeaderCollection()
		{
		}

		private void add(string name, string value, bool ignoreRestricted)
		{
		}

		private void addWithoutCheckingName(string name, string value)
		{
		}

		private void addWithoutCheckingNameAndRestricted(string name, string value)
		{
		}

		private static int checkColonSeparated(string header)
		{
			return 0;
		}

		private static HttpHeaderType checkHeaderType(string name)
		{
			return default(HttpHeaderType);
		}

		private static string checkName(string name)
		{
			return null;
		}

		private void checkRestricted(string name)
		{
		}

		private void checkState(bool response)
		{
		}

		private static string checkValue(string value)
		{
			return null;
		}

		private static string convert(string key)
		{
			return null;
		}

		private void doWithCheckingState(Action<string, string> action, string name, string value, bool setState)
		{
		}

		private void doWithCheckingState(Action<string, string> action, string name, string value, bool response, bool setState)
		{
		}

		private void doWithoutCheckingName(Action<string, string> action, string name, string value)
		{
		}

		private static HttpHeaderInfo getHeaderInfo(string name)
		{
			return null;
		}

		private static bool isRestricted(string name, bool response)
		{
			return false;
		}

		private void removeWithoutCheckingName(string name, string unuse)
		{
		}

		private void setWithoutCheckingName(string name, string value)
		{
		}

		internal static string Convert(HttpRequestHeader header)
		{
			return null;
		}

		internal static string Convert(HttpResponseHeader header)
		{
			return null;
		}

		internal void InternalRemove(string name)
		{
		}

		internal void InternalSet(string header, bool response)
		{
		}

		internal void InternalSet(string name, string value, bool response)
		{
		}

		internal static bool IsHeaderName(string name)
		{
			return false;
		}

		internal static bool IsHeaderValue(string value)
		{
			return false;
		}

		internal static bool IsMultiValue(string headerName, bool response)
		{
			return false;
		}

		internal string ToStringMultiValue(bool response)
		{
			return null;
		}

		protected void AddWithoutValidate(string headerName, string headerValue)
		{
		}

		public void Add(string header)
		{
		}

		public void Add(HttpRequestHeader header, string value)
		{
		}

		public void Add(HttpResponseHeader header, string value)
		{
		}

		public override void Add(string name, string value)
		{
		}

		public override void Clear()
		{
		}

		public override string Get(int index)
		{
			return null;
		}

		public override string Get(string name)
		{
			return null;
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string GetKey(int index)
		{
			return null;
		}

		public override string[] GetValues(int index)
		{
			return null;
		}

		public override string[] GetValues(string header)
		{
			return null;
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public static bool IsRestricted(string headerName)
		{
			return false;
		}

		public static bool IsRestricted(string headerName, bool response)
		{
			return false;
		}

		public override void OnDeserialization(object sender)
		{
		}

		public void Remove(HttpRequestHeader header)
		{
		}

		public void Remove(HttpResponseHeader header)
		{
		}

		public override void Remove(string name)
		{
		}

		public void Set(HttpRequestHeader header, string value)
		{
		}

		public void Set(HttpResponseHeader header, string value)
		{
		}

		public override void Set(string name, string value)
		{
		}

		public byte[] ToByteArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private void System_002ERuntime_002ESerialization_002EISerializable_002EGetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
