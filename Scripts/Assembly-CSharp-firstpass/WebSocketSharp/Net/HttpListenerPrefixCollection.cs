using System;
using System.Collections;
using System.Collections.Generic;

namespace WebSocketSharp.Net
{
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		private HttpListener _listener;

		private List<string> _prefixes;

		public int Count => 0;

		public bool IsReadOnly => false;

		public bool IsSynchronized => false;

		internal HttpListenerPrefixCollection(HttpListener listener)
		{
		}

		public void Add(string uriPrefix)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(string uriPrefix)
		{
			return false;
		}

		public void CopyTo(Array array, int offset)
		{
		}

		public void CopyTo(string[] array, int offset)
		{
		}

		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		public bool Remove(string uriPrefix)
		{
			return false;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
