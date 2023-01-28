using System;
using System.Collections;

namespace UniRx
{
	public static class Tuple
	{
		public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			return null;
		}

		public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			return default(Tuple<T1, T2, T3, T4, T5, T6, T7>);
		}

		public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			return default(Tuple<T1, T2, T3, T4, T5, T6>);
		}

		public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			return default(Tuple<T1, T2, T3, T4, T5>);
		}

		public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return default(Tuple<T1, T2, T3, T4>);
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return default(Tuple<T1, T2, T3>);
		}

		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return default(Tuple<T1, T2>);
		}

		public static Tuple<T1> Create<T1>(T1 item1)
		{
			return default(Tuple<T1>);
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		private T6 item6;

		private T7 item7;

		private TRest rest;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public T4 Item4 => default(T4);

		public T5 Item5 => default(T5);

		public T6 Item6 => default(T6);

		public T7 Item7 => default(T7);

		public TRest Rest => default(TRest);

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1>>
	{
		private T1 item1;

		public T1 Item1 => default(T1);

		public Tuple(T1 item1)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2>>
	{
		private T1 item1;

		private T2 item2;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public Tuple(T1 item1, T2 item2)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2, T3>>
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2, T3> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2, T3, T4>>
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public T4 Item4 => default(T4);

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2, T3, T4> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2, T3, T4, T5>>
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public T4 Item4 => default(T4);

		public T5 Item5 => default(T5);

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2, T3, T4, T5> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2, T3, T4, T5, T6>>
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		private T6 item6;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public T4 Item4 => default(T4);

		public T5 Item5 => default(T5);

		public T6 Item6 => default(T6);

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2, T3, T4, T5, T6> other)
		{
			return false;
		}
	}
	[Serializable]
	public struct Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple, IEquatable<Tuple<T1, T2, T3, T4, T5, T6, T7>>
	{
		private T1 item1;

		private T2 item2;

		private T3 item3;

		private T4 item4;

		private T5 item5;

		private T6 item6;

		private T7 item7;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public T4 Item4 => default(T4);

		public T5 Item5 => default(T5);

		public T6 Item6 => default(T6);

		public T7 Item7 => default(T7);

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		private int UniRx_002EIStructuralComparable_002ECompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private bool UniRx_002EIStructuralEquatable_002EEquals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int UniRx_002EIStructuralEquatable_002EGetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private string UniRx_002EITuple_002EToString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Tuple<T1, T2, T3, T4, T5, T6, T7> other)
		{
			return false;
		}
	}
}
