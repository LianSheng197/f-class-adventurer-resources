using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal abstract class MinimumBinaryHeap
	{
	}
	internal class MinimumBinaryHeap<T> : MinimumBinaryHeap
	{
		private readonly IComparer<T> m_Comparer;

		private readonly int m_MinimumCapacity;

		private T[] m_HeapArray;

		public int Count
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public T Min => default(T);

		public MinimumBinaryHeap(IComparer<T> comparer, int minimumCapacity = 10)
		{
		}

		internal MinimumBinaryHeap(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10)
		{
		}

		public void Insert(T data)
		{
		}

		private void IncreaseHeapCapacityWhenFull()
		{
		}

		public void Remove(T data)
		{
		}

		public T ExtractMin()
		{
			return default(T);
		}

		private void DecreaseHeapCapacityWhenSpare()
		{
		}

		private int GetKey(T data)
		{
			return 0;
		}

		private void MinHeapify()
		{
		}

		private static void Swap(ref T lhs, ref T rhs)
		{
		}

		private static int Parent(int key)
		{
			return 0;
		}

		private static int LeftChild(int key)
		{
			return 0;
		}

		private static int RightChild(int key)
		{
			return 0;
		}
	}
}
