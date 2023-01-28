using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace WebSocketSharp.Net
{
	[Serializable]
	[DefaultMember("Item")]
	public class CookieCollection : ICollection, IEnumerable
	{
		private List<Cookie> _list;

		private object _sync;

		internal IList<Cookie> List => null;

		internal IEnumerable<Cookie> Sorted => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		public bool IsSynchronized => false;

		public Cookie Item => null;

		public Cookie Item => null;

		public object SyncRoot => null;

		private static int compareCookieWithinSort(Cookie x, Cookie y)
		{
			return 0;
		}

		private static int compareCookieWithinSorted(Cookie x, Cookie y)
		{
			return 0;
		}

		private static CookieCollection parseRequest(string value)
		{
			return null;
		}

		private static CookieCollection parseResponse(string value)
		{
			return null;
		}

		private int searchCookie(Cookie cookie)
		{
			return 0;
		}

		private static string[] splitCookieHeaderValue(string value)
		{
			return null;
		}

		internal static CookieCollection Parse(string value, bool response)
		{
			return null;
		}

		internal void SetOrRemove(Cookie cookie)
		{
		}

		internal void SetOrRemove(CookieCollection cookies)
		{
		}

		internal void Sort()
		{
		}

		public void Add(Cookie cookie)
		{
		}

		public void Add(CookieCollection cookies)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public void CopyTo(Cookie[] array, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
