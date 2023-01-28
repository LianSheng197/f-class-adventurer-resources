using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("simple-json", "1.0.0")]
	[DefaultMember("Item")]
	public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private readonly Dictionary<string, object> _members;

		public object Item => null;

		public ICollection<string> Keys => null;

		public ICollection<object> Values => null;

		public object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public JsonObject()
		{
		}

		public JsonObject(IEqualityComparer<string> comparer)
		{
		}

		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			return null;
		}

		public void Add(string key, object value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out object value)
		{
			value = null;
			return false;
		}

		public void Add(KeyValuePair<string, object> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<string, object> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<string, object> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
