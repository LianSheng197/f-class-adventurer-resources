using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	[DefaultMember("Item")]
	public class ReactiveDictionary<TKey, TValue> : IReactiveDictionary<TKey, TValue>, IReadOnlyReactiveDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IDisposable, ISerializable, IDeserializationCallback
	{
		[NonSerialized]
		private bool isDisposed;

		[SerializeField]
		private readonly Dictionary<TKey, TValue> inner;

		private bool disposedValue;

		[NonSerialized]
		private Subject<int> countChanged;

		[NonSerialized]
		private Subject<Unit> collectionReset;

		[NonSerialized]
		private Subject<DictionaryAddEvent<TKey, TValue>> dictionaryAdd;

		[NonSerialized]
		private Subject<DictionaryRemoveEvent<TKey, TValue>> dictionaryRemove;

		[NonSerialized]
		private Subject<DictionaryReplaceEvent<TKey, TValue>> dictionaryReplace;

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

		private object System_002ECollections_002EIDictionary_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private bool System_002ECollections_002EIDictionary_002EIsReadOnly => false;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EIsReadOnly => false;

		private ICollection<TKey> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EKeys => null;

		private ICollection<TValue> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EValues => null;

		public ReactiveDictionary()
		{
		}

		public ReactiveDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		public ReactiveDictionary(Dictionary<TKey, TValue> innerDictionary)
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

		private void DisposeSubject<TSubject>(ref Subject<TSubject> subject)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		public IObservable<int> ObserveCountChanged()
		{
			return null;
		}

		public IObservable<Unit> ObserveReset()
		{
			return null;
		}

		public IObservable<DictionaryAddEvent<TKey, TValue>> ObserveAdd()
		{
			return null;
		}

		public IObservable<DictionaryRemoveEvent<TKey, TValue>> ObserveRemove()
		{
			return null;
		}

		public IObservable<DictionaryReplaceEvent<TKey, TValue>> ObserveReplace()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return false;
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public void OnDeserialization(object sender)
		{
		}

		private void System_002ECollections_002EIDictionary_002ERemove(object key)
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

		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}
	}
}
