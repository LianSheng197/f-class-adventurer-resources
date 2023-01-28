using System;
using System.Collections;
using System.Collections.Specialized;

namespace LitJson
{
	public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IDictionary, IEnumerable, IOrderedDictionary
	{
		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		private object System_002ECollections_002EIList_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private int System_002ECollections_002EICollection_002ECount => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private bool System_002ECollections_002EIDictionary_002EIsReadOnly => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

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

		private object System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsArray => false;

		public bool IsBoolean => false;

		public bool IsDouble => false;

		public bool IsInt => false;

		public bool IsLong => false;

		public bool IsObject => false;

		public bool IsString => false;

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EInsert(int i, object v)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002EAdd(object k, object v)
		{
		}

		private void System_002ECollections_002EIDictionary_002EClear()
		{
		}

		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return false;
		}

		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		private IDictionaryEnumerator System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002EInsert(int i, object k, object v)
		{
		}

		private void System_002ECollections_002ESpecialized_002EIOrderedDictionary_002ERemoveAt(int i)
		{
		}

		public bool GetBoolean()
		{
			return false;
		}

		public double GetDouble()
		{
			return 0.0;
		}

		public int GetInt()
		{
			return 0;
		}

		public JsonType GetJsonType()
		{
			return default(JsonType);
		}

		public long GetLong()
		{
			return 0L;
		}

		public string GetString()
		{
			return null;
		}

		public void SetBoolean(bool val)
		{
		}

		public void SetDouble(double val)
		{
		}

		public void SetInt(int val)
		{
		}

		public void SetJsonType(JsonType type)
		{
		}

		public void SetLong(long val)
		{
		}

		public void SetString(string val)
		{
		}

		public string ToJson()
		{
			return null;
		}

		public void ToJson(JsonWriter writer)
		{
		}
	}
}
