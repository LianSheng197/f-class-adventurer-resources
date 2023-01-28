using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public struct CollectionRemoveEvent<T> : IEquatable<CollectionRemoveEvent<T>>
	{
		public int Index
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

		public CollectionRemoveEvent(int index, T value)
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

		public bool Equals(CollectionRemoveEvent<T> other)
		{
			return false;
		}
	}
}
