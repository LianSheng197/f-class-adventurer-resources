using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace UniRx
{
	[DefaultMember("Item")]
	public sealed class DictionaryDisposable<TKey, TValue> : IDisposable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TValue : IDisposable
	{
		private bool isDisposed;

		private readonly Dictionary<TKey, TValue> inner;

		public TValue Item
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public int Count => 0;

		public Dictionary<TKey, TValue>.KeyCollection Keys => null;

		public Dictionary<TKey, TValue>.ValueCollection Values => null;

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EIsReadOnly => false;

		private ICollection<TKey> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EKeys => null;

		private ICollection<TValue> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EValues => null;

		public DictionaryDisposable()
		{
		}

		public DictionaryDisposable(IEqualityComparer<TKey> comparer)
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void Clear()
		{
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(Dictionary<TKey, TValue>.Enumerator);
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public void OnDeserialization(object sender)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EAdd(KeyValuePair<TKey, TValue> item)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EContains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ECopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		private IEnumerator<KeyValuePair<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ERemove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public void Dispose()
		{
		}
	}
}
