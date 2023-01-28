using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Cloud
{
	[DefaultMember("Item")]
	public class CyclicalList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int currentIndex;

			private CyclicalList<T> list;

			public T Current => default(T);

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			public Enumerator(CyclicalList<T> list)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private int count;

		private T[] items;

		private int nextPointer;

		public int Capacity => 0;

		public int Count => 0;

		public bool IsReadOnly => false;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public CyclicalList(int capacity)
		{
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public T GetNextEviction()
		{
			return default(T);
		}

		private int GetPointer(int index)
		{
			return 0;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}
	}
}
