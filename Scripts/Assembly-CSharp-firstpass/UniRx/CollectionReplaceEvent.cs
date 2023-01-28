using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public struct CollectionReplaceEvent<T> : IEquatable<CollectionReplaceEvent<T>>
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

		public T OldValue
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

		public T NewValue
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

		public CollectionReplaceEvent(int index, T oldValue, T newValue)
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

		public bool Equals(CollectionReplaceEvent<T> other)
		{
			return false;
		}
	}
}
