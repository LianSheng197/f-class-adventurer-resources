using System;
using System.Runtime.CompilerServices;

namespace UniRx
{
	public struct DictionaryAddEvent<TKey, TValue> : IEquatable<DictionaryAddEvent<TKey, TValue>>
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

		public DictionaryAddEvent(TKey key, TValue value)
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

		public bool Equals(DictionaryAddEvent<TKey, TValue> other)
		{
			return false;
		}
	}
}
