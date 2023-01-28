using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Firebase.Auth
{
	[DefaultMember("Item")]
	internal class UserInfoInterfaceList : IDisposable, IEnumerable, IList<UserInfoInterface>, ICollection<UserInfoInterface>, IEnumerable<UserInfoInterface>
	{
		public sealed class UserInfoInterfaceListEnumerator : IEnumerator, IEnumerator<UserInfoInterface>, IDisposable
		{
			private UserInfoInterfaceList collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UserInfoInterface Current => null;

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public UserInfoInterfaceListEnumerator(UserInfoInterfaceList collection)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public UserInfoInterface Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsSynchronized => false;

		internal UserInfoInterfaceList(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(UserInfoInterfaceList obj)
		{
			return default(HandleRef);
		}

		~UserInfoInterfaceList()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public UserInfoInterfaceList(IEnumerable c)
		{
		}

		public UserInfoInterfaceList(IEnumerable<UserInfoInterface> c)
		{
		}

		public void CopyTo(UserInfoInterface[] array)
		{
		}

		public void CopyTo(UserInfoInterface[] array, int arrayIndex)
		{
		}

		public void CopyTo(int index, UserInfoInterface[] array, int arrayIndex, int count)
		{
		}

		public UserInfoInterface[] ToArray()
		{
			return null;
		}

		private IEnumerator<UserInfoInterface> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CFirebase_002EAuth_002EUserInfoInterface_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public UserInfoInterfaceListEnumerator GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(UserInfoInterface x)
		{
		}

		private uint size()
		{
			return 0u;
		}

		private uint capacity()
		{
			return 0u;
		}

		private void reserve(uint n)
		{
		}

		public UserInfoInterfaceList()
		{
		}

		public UserInfoInterfaceList(UserInfoInterfaceList other)
		{
		}

		public UserInfoInterfaceList(int capacity)
		{
		}

		private UserInfoInterface getitemcopy(int index)
		{
			return null;
		}

		private UserInfoInterface getitem(int index)
		{
			return null;
		}

		private void setitem(int index, UserInfoInterface val)
		{
		}

		public void AddRange(UserInfoInterfaceList values)
		{
		}

		public UserInfoInterfaceList GetRange(int index, int count)
		{
			return null;
		}

		public void Insert(int index, UserInfoInterface x)
		{
		}

		public void InsertRange(int index, UserInfoInterfaceList values)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public static UserInfoInterfaceList Repeat(UserInfoInterface value, int count)
		{
			return null;
		}

		public void Reverse()
		{
		}

		public void Reverse(int index, int count)
		{
		}

		public void SetRange(int index, UserInfoInterfaceList values)
		{
		}

		public bool Contains(UserInfoInterface value)
		{
			return false;
		}

		public int IndexOf(UserInfoInterface value)
		{
			return 0;
		}

		public int LastIndexOf(UserInfoInterface value)
		{
			return 0;
		}

		public bool Remove(UserInfoInterface value)
		{
			return false;
		}
	}
}
