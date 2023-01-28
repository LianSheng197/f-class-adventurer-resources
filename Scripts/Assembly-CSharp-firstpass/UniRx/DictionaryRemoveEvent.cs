using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public struct DictionaryRemoveEvent<TKey, TValue> : IEquatable<DictionaryRemoveEvent<TKey, TValue>>
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

		public TValue Value
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

		public DictionaryRemoveEvent(TKey key, TValue value)
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

		public bool Equals(DictionaryRemoveEvent<TKey, TValue> other)
		{
			return false;
		}
	}
}
