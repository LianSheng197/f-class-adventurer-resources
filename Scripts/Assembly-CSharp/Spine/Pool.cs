using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Spine
{
	public class Pool<T> where T : class, new()
	{
		public interface IPoolable
		{
			void Reset();
		}

		public readonly int max;

		private readonly Stack<T> freeObjects;

		public int Count => 0;

		public int Peak
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

		public Pool(int initialCapacity = 16, int max = int.MaxValue)
		{
		}

		public T Obtain()
		{
			return null;
		}

		public void Free(T obj)
		{
		}

		public void Clear()
		{
		}

		protected void Reset(T obj)
		{
		}
	}
}
