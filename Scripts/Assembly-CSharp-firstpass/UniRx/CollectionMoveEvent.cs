using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public struct CollectionMoveEvent<T> : IEquatable<CollectionMoveEvent<T>>
	{
		public int OldIndex
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int NewIndex
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public T Value
		{
			[CompilerGenerated]
			readonly get
			{
				return default(T);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CollectionMoveEvent(int oldIndex, int newIndex, T value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(CollectionMoveEvent<T> other)
		{
			return false;
		}
	}
}
