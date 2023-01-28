using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public struct DictionaryReplaceEvent<TKey, TValue> : IEquatable<DictionaryReplaceEvent<TKey, TValue>>
	{
		public TKey Key
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TKey);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TValue OldValue
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TValue);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TValue NewValue
		{
			[CompilerGenerated]
			readonly get
			{
				return default(TValue);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DictionaryReplaceEvent(TKey key, TValue oldValue, TValue newValue)
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

		public bool Equals(DictionaryReplaceEvent<TKey, TValue> other)
		{
			return false;
		}
	}
}
