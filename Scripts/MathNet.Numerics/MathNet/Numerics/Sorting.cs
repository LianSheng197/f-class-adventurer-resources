using System.Collections.Generic;

namespace MathNet.Numerics
{
	public static class Sorting
	{
		public static void Sort<T>(IList<T> keys, IComparer<T> comparer = null)
		{
		}

		public static void Sort<TKey, TItem>(IList<TKey> keys, IList<TItem> items, IComparer<TKey> comparer = null)
		{
		}

		public static void Sort<TKey, TItem1, TItem2>(IList<TKey> keys, IList<TItem1> items1, IList<TItem2> items2, IComparer<TKey> comparer = null)
		{
		}

		public static void Sort<T>(IList<T> keys, int index, int count, IComparer<T> comparer = null)
		{
		}

		public static void Sort<TKey, TItem>(IList<TKey> keys, IList<TItem> items, int index, int count, IComparer<TKey> comparer = null)
		{
		}

		public static void Sort<TKey, TItem1, TItem2>(IList<TKey> keys, IList<TItem1> items1, IList<TItem2> items2, int index, int count, IComparer<TKey> comparer = null)
		{
		}

		public static void SortAll<T1, T2>(IList<T1> primary, IList<T2> secondary, IComparer<T1> primaryComparer = null, IComparer<T2> secondaryComparer = null)
		{
		}

		private static void QuickSort<T>(IList<T> keys, IComparer<T> comparer, int left, int right)
		{
		}

		private static void QuickSort<T, TItems>(IList<T> keys, IList<TItems> items, IComparer<T> comparer, int left, int right)
		{
		}

		private static void QuickSort<T, TItems1, TItems2>(IList<T> keys, IList<TItems1> items1, IList<TItems2> items2, IComparer<T> comparer, int left, int right)
		{
		}

		private static void QuickSortAll<T1, T2>(IList<T1> primary, IList<T2> secondary, IComparer<T1> primaryComparer, IComparer<T2> secondaryComparer, int left, int right)
		{
		}

		private static void Swap<T>(IList<T> keys, int a, int b)
		{
		}
	}
}
