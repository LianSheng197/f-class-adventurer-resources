using System;

namespace UniRx
{
	[Serializable]
	public struct Pair<T> : IEquatable<Pair<T>>
	{
		private readonly T previous;

		private readonly T current;

		public T Previous => default(T);

		public T Current => default(T);

		public Pair(T previous, T current)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Pair<T> other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
