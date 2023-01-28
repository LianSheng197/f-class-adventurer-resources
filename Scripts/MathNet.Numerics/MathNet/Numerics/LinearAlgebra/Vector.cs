using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra
{
	[Serializable]
	[DefaultMember("Item")]
	[DebuggerDisplay("Vector {Count}")]
	public abstract class Vector<T> : IFormattable, IEquatable<Vector<T>>, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T>, ICloneable where T : struct, IEquatable<T>, IFormattable
	{
		public static readonly T Zero;

		public static readonly T One;

		public static readonly VectorBuilder<T> Build;

		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private object System_002ECollections_002EIList_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		public VectorStorage<T> Storage
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

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

		public T Item
		{
			[MethodImpl(256)]
			[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
			get
			{
				return default(T);
			}
			[MethodImpl(256)]
			[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
			set
			{
			}
		}

		protected abstract void DoNegate(Vector<T> result);

		protected abstract void DoConjugate(Vector<T> result);

		protected abstract void DoAdd(T scalar, Vector<T> result);

		protected abstract void DoAdd(Vector<T> other, Vector<T> result);

		protected abstract void DoSubtract(T scalar, Vector<T> result);

		protected void DoSubtractFrom(T scalar, Vector<T> result)
		{
		}

		protected abstract void DoSubtract(Vector<T> other, Vector<T> result);

		protected abstract void DoMultiply(T scalar, Vector<T> result);

		protected abstract T DoDotProduct(Vector<T> other);

		protected abstract T DoConjugateDotProduct(Vector<T> other);

		protected void DoOuterProduct(Vector<T> other, Matrix<T> result)
		{
		}

		protected abstract void DoDivide(T divisor, Vector<T> result);

		protected abstract void DoDivideByThis(T dividend, Vector<T> result);

		protected abstract void DoModulus(T divisor, Vector<T> result);

		protected abstract void DoModulusByThis(T dividend, Vector<T> result);

		protected abstract void DoRemainder(T divisor, Vector<T> result);

		protected abstract void DoRemainderByThis(T dividend, Vector<T> result);

		protected abstract void DoPointwiseMultiply(Vector<T> other, Vector<T> result);

		protected abstract void DoPointwiseDivide(Vector<T> divisor, Vector<T> result);

		protected abstract void DoPointwisePower(T exponent, Vector<T> result);

		protected abstract void DoPointwisePower(Vector<T> exponent, Vector<T> result);

		protected abstract void DoPointwiseModulus(Vector<T> divisor, Vector<T> result);

		protected abstract void DoPointwiseRemainder(Vector<T> divisor, Vector<T> result);

		protected abstract void DoPointwiseExp(Vector<T> result);

		protected abstract void DoPointwiseLog(Vector<T> result);

		protected abstract void DoPointwiseAbs(Vector<T> result);

		protected abstract void DoPointwiseAcos(Vector<T> result);

		protected abstract void DoPointwiseAsin(Vector<T> result);

		protected abstract void DoPointwiseAtan(Vector<T> result);

		protected abstract void DoPointwiseCeiling(Vector<T> result);

		protected abstract void DoPointwiseCos(Vector<T> result);

		protected abstract void DoPointwiseCosh(Vector<T> result);

		protected abstract void DoPointwiseFloor(Vector<T> result);

		protected abstract void DoPointwiseLog10(Vector<T> result);

		protected abstract void DoPointwiseRound(Vector<T> result);

		protected abstract void DoPointwiseSign(Vector<T> result);

		protected abstract void DoPointwiseSin(Vector<T> result);

		protected abstract void DoPointwiseSinh(Vector<T> result);

		protected abstract void DoPointwiseSqrt(Vector<T> result);

		protected abstract void DoPointwiseTan(Vector<T> result);

		protected abstract void DoPointwiseTanh(Vector<T> result);

		protected abstract void DoPointwiseAtan2(Vector<T> other, Vector<T> result);

		protected abstract void DoPointwiseAtan2(T scalar, Vector<T> result);

		protected abstract void DoPointwiseMinimum(T scalar, Vector<T> result);

		protected abstract void DoPointwiseMinimum(Vector<T> other, Vector<T> result);

		protected abstract void DoPointwiseMaximum(T scalar, Vector<T> result);

		protected abstract void DoPointwiseMaximum(Vector<T> other, Vector<T> result);

		protected abstract void DoPointwiseAbsoluteMinimum(T scalar, Vector<T> result);

		protected abstract void DoPointwiseAbsoluteMinimum(Vector<T> other, Vector<T> result);

		protected abstract void DoPointwiseAbsoluteMaximum(T scalar, Vector<T> result);

		protected abstract void DoPointwiseAbsoluteMaximum(Vector<T> other, Vector<T> result);

		public Vector<T> Add(T scalar)
		{
			return null;
		}

		public void Add(T scalar, Vector<T> result)
		{
		}

		public Vector<T> Add(Vector<T> other)
		{
			return null;
		}

		public void Add(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> Subtract(T scalar)
		{
			return null;
		}

		public void Subtract(T scalar, Vector<T> result)
		{
		}

		public Vector<T> SubtractFrom(T scalar)
		{
			return null;
		}

		public void SubtractFrom(T scalar, Vector<T> result)
		{
		}

		public Vector<T> Negate()
		{
			return null;
		}

		public void Negate(Vector<T> result)
		{
		}

		public Vector<T> Subtract(Vector<T> other)
		{
			return null;
		}

		public void Subtract(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> Conjugate()
		{
			return null;
		}

		public void Conjugate(Vector<T> result)
		{
		}

		public Vector<T> Multiply(T scalar)
		{
			return null;
		}

		public void Multiply(T scalar, Vector<T> result)
		{
		}

		public T DotProduct(Vector<T> other)
		{
			return default(T);
		}

		public T ConjugateDotProduct(Vector<T> other)
		{
			return default(T);
		}

		public Vector<T> Divide(T scalar)
		{
			return null;
		}

		public void Divide(T scalar, Vector<T> result)
		{
		}

		public Vector<T> DivideByThis(T scalar)
		{
			return null;
		}

		public void DivideByThis(T scalar, Vector<T> result)
		{
		}

		public Vector<T> Modulus(T divisor)
		{
			return null;
		}

		public void Modulus(T divisor, Vector<T> result)
		{
		}

		public Vector<T> ModulusByThis(T dividend)
		{
			return null;
		}

		public void ModulusByThis(T dividend, Vector<T> result)
		{
		}

		public Vector<T> Remainder(T divisor)
		{
			return null;
		}

		public void Remainder(T divisor, Vector<T> result)
		{
		}

		public Vector<T> RemainderByThis(T dividend)
		{
			return null;
		}

		public void RemainderByThis(T dividend, Vector<T> result)
		{
		}

		public Vector<T> PointwiseMultiply(Vector<T> other)
		{
			return null;
		}

		public void PointwiseMultiply(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> PointwiseDivide(Vector<T> divisor)
		{
			return null;
		}

		public void PointwiseDivide(Vector<T> divisor, Vector<T> result)
		{
		}

		public Vector<T> PointwisePower(T exponent)
		{
			return null;
		}

		public void PointwisePower(T exponent, Vector<T> result)
		{
		}

		public Vector<T> PointwisePower(Vector<T> exponent)
		{
			return null;
		}

		public void PointwisePower(Vector<T> exponent, Vector<T> result)
		{
		}

		public Vector<T> PointwiseModulus(Vector<T> divisor)
		{
			return null;
		}

		public void PointwiseModulus(Vector<T> divisor, Vector<T> result)
		{
		}

		public Vector<T> PointwiseRemainder(Vector<T> divisor)
		{
			return null;
		}

		public void PointwiseRemainder(Vector<T> divisor, Vector<T> result)
		{
		}

		protected Vector<T> PointwiseUnary(Action<Vector<T>> f)
		{
			return null;
		}

		protected void PointwiseUnary(Action<Vector<T>> f, Vector<T> result)
		{
		}

		protected Vector<T> PointwiseBinary(Action<T, Vector<T>> f, T other)
		{
			return null;
		}

		protected void PointwiseBinary(Action<T, Vector<T>> f, T x, Vector<T> result)
		{
		}

		protected Vector<T> PointwiseBinary(Action<Vector<T>, Vector<T>> f, Vector<T> other)
		{
			return null;
		}

		protected void PointwiseBinary(Action<Vector<T>, Vector<T>> f, Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> PointwiseExp()
		{
			return null;
		}

		public void PointwiseExp(Vector<T> result)
		{
		}

		public Vector<T> PointwiseLog()
		{
			return null;
		}

		public void PointwiseLog(Vector<T> result)
		{
		}

		public Vector<T> PointwiseAbs()
		{
			return null;
		}

		public void PointwiseAbs(Vector<T> result)
		{
		}

		public Vector<T> PointwiseAcos()
		{
			return null;
		}

		public void PointwiseAcos(Vector<T> result)
		{
		}

		public Vector<T> PointwiseAsin()
		{
			return null;
		}

		public void PointwiseAsin(Vector<T> result)
		{
		}

		public Vector<T> PointwiseAtan()
		{
			return null;
		}

		public void PointwiseAtan(Vector<T> result)
		{
		}

		public Vector<T> PointwiseAtan2(Vector<T> other)
		{
			return null;
		}

		public void PointwiseAtan2(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> PointwiseCeiling()
		{
			return null;
		}

		public void PointwiseCeiling(Vector<T> result)
		{
		}

		public Vector<T> PointwiseCos()
		{
			return null;
		}

		public void PointwiseCos(Vector<T> result)
		{
		}

		public Vector<T> PointwiseCosh()
		{
			return null;
		}

		public void PointwiseCosh(Vector<T> result)
		{
		}

		public Vector<T> PointwiseFloor()
		{
			return null;
		}

		public void PointwiseFloor(Vector<T> result)
		{
		}

		public Vector<T> PointwiseLog10()
		{
			return null;
		}

		public void PointwiseLog10(Vector<T> result)
		{
		}

		public Vector<T> PointwiseRound()
		{
			return null;
		}

		public void PointwiseRound(Vector<T> result)
		{
		}

		public Vector<T> PointwiseSign()
		{
			return null;
		}

		public void PointwiseSign(Vector<T> result)
		{
		}

		public Vector<T> PointwiseSin()
		{
			return null;
		}

		public void PointwiseSin(Vector<T> result)
		{
		}

		public Vector<T> PointwiseSinh()
		{
			return null;
		}

		public void PointwiseSinh(Vector<T> result)
		{
		}

		public Vector<T> PointwiseSqrt()
		{
			return null;
		}

		public void PointwiseSqrt(Vector<T> result)
		{
		}

		public Vector<T> PointwiseTan()
		{
			return null;
		}

		public void PointwiseTan(Vector<T> result)
		{
		}

		public Vector<T> PointwiseTanh()
		{
			return null;
		}

		public void PointwiseTanh(Vector<T> result)
		{
		}

		public Matrix<T> OuterProduct(Vector<T> other)
		{
			return null;
		}

		public void OuterProduct(Vector<T> other, Matrix<T> result)
		{
		}

		public static Matrix<T> OuterProduct(Vector<T> u, Vector<T> v)
		{
			return null;
		}

		public Vector<T> PointwiseMinimum(T scalar)
		{
			return null;
		}

		public void PointwiseMinimum(T scalar, Vector<T> result)
		{
		}

		public Vector<T> PointwiseMaximum(T scalar)
		{
			return null;
		}

		public void PointwiseMaximum(T scalar, Vector<T> result)
		{
		}

		public Vector<T> PointwiseAbsoluteMinimum(T scalar)
		{
			return null;
		}

		public void PointwiseAbsoluteMinimum(T scalar, Vector<T> result)
		{
		}

		public Vector<T> PointwiseAbsoluteMaximum(T scalar)
		{
			return null;
		}

		public void PointwiseAbsoluteMaximum(T scalar, Vector<T> result)
		{
		}

		public Vector<T> PointwiseMinimum(Vector<T> other)
		{
			return null;
		}

		public void PointwiseMinimum(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> PointwiseMaximum(Vector<T> other)
		{
			return null;
		}

		public void PointwiseMaximum(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> PointwiseAbsoluteMinimum(Vector<T> other)
		{
			return null;
		}

		public void PointwiseAbsoluteMinimum(Vector<T> other, Vector<T> result)
		{
		}

		public Vector<T> PointwiseAbsoluteMaximum(Vector<T> other)
		{
			return null;
		}

		public void PointwiseAbsoluteMaximum(Vector<T> other, Vector<T> result)
		{
		}

		public abstract double L1Norm();

		public abstract double L2Norm();

		public abstract double InfinityNorm();

		public abstract double Norm(double p);

		public abstract Vector<T> Normalize(double p);

		public abstract T AbsoluteMinimum();

		public abstract int AbsoluteMinimumIndex();

		public abstract T AbsoluteMaximum();

		public abstract int AbsoluteMaximumIndex();

		public T Maximum()
		{
			return default(T);
		}

		public abstract int MaximumIndex();

		public T Minimum()
		{
			return default(T);
		}

		public abstract int MinimumIndex();

		public abstract T Sum();

		public double SumMagnitudes()
		{
			return 0.0;
		}

		public bool Equals(Vector<T> other)
		{
			return false;
		}

		public sealed override bool Equals(object obj)
		{
			return false;
		}

		public sealed override int GetHashCode()
		{
			return 0;
		}

		private object System_002EICloneable_002EClone()
		{
			return null;
		}

		private int System_002ECollections_002EGeneric_002EIList_003CT_003E_002EIndexOf(T item)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CT_003E_002EInsert(int index, T item)
		{
		}

		private void System_002ECollections_002EGeneric_002EIList_003CT_003E_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EAdd(T item)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ERemove(T item)
		{
			return false;
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EContains(T item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ECopyTo(T[] array, int arrayIndex)
		{
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public virtual string ToTypeString()
		{
			return null;
		}

		public string[,] ToVectorStringArray(int maxPerColumn, int maxCharactersWidth, int padding, string ellipsis, Func<T, string> formatValue)
		{
			return null;
		}

		private static string FormatStringArrayToString(string[,] array, string columnSeparator, string rowSeparator)
		{
			return null;
		}

		private Tuple<int, string[]> FormatCompleteColumn(int offset, int height, Func<T, string> formatValue)
		{
			return null;
		}

		public string ToVectorString(int maxPerColumn, int maxCharactersWidth, string ellipsis, string columnSeparator, string rowSeparator, Func<T, string> formatValue)
		{
			return null;
		}

		public string ToVectorString(int maxPerColumn, int maxCharactersWidth, string format = null, IFormatProvider provider = null)
		{
			return null;
		}

		public string ToVectorString(string format = null, IFormatProvider provider = null)
		{
			return null;
		}

		public string ToString(int maxPerColumn, int maxCharactersWidth, string format = null, IFormatProvider provider = null)
		{
			return null;
		}

		public sealed override string ToString()
		{
			return null;
		}

		public string ToString(string format = null, IFormatProvider formatProvider = null)
		{
			return null;
		}

		protected Vector(VectorStorage<T> storage)
		{
		}

		[MethodImpl(256)]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public T At(int index)
		{
			return default(T);
		}

		[MethodImpl(256)]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public void At(int index, T value)
		{
		}

		public void Clear()
		{
		}

		public void ClearSubVector(int index, int count)
		{
		}

		public abstract void CoerceZero(double threshold);

		public void CoerceZero(Func<T, bool> zeroPredicate)
		{
		}

		public Vector<T> Clone()
		{
			return null;
		}

		public void SetValues(T[] values)
		{
		}

		public void CopyTo(Vector<T> target)
		{
		}

		public Vector<T> SubVector(int index, int count)
		{
			return null;
		}

		public void SetSubVector(int index, int count, Vector<T> subVector)
		{
		}

		public void CopySubVectorTo(Vector<T> destination, int sourceIndex, int targetIndex, int count)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public T[] AsArray()
		{
			return null;
		}

		public Matrix<T> ToColumnMatrix()
		{
			return null;
		}

		public Matrix<T> ToRowMatrix()
		{
			return null;
		}

		public IEnumerable<T> Enumerate()
		{
			return null;
		}

		public IEnumerable<T> Enumerate(Zeros zeros)
		{
			return null;
		}

		public IEnumerable<(int, T)> EnumerateIndexed()
		{
			return null;
		}

		public IEnumerable<(int, T)> EnumerateIndexed(Zeros zeros)
		{
			return null;
		}

		public void MapInplace(Func<T, T> f, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void MapIndexedInplace(Func<int, T, T> f, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void Map(Func<T, T> f, Vector<T> result, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void MapIndexed(Func<int, T, T> f, Vector<T> result, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void MapConvert<TU>(Func<T, TU> f, Vector<TU> result, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void MapIndexedConvert<TU>(Func<int, T, TU> f, Vector<TU> result, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public Vector<TU> Map<TU>(Func<T, TU> f, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Vector<TU> MapIndexed<TU>(Func<int, T, TU> f, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public void Map2(Func<T, T, T> f, Vector<T> other, Vector<T> result, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public Vector<T> Map2(Func<T, T, T> f, Vector<T> other, Zeros zeros = Zeros.AllowSkip)
		{
			return null;
		}

		public TState Fold2<TOther, TState>(Func<TState, T, TOther, TState> f, TState state, Vector<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return default(TState);
		}

		public Tuple<int, T> Find(Func<T, bool> predicate, Zeros zeros = Zeros.AllowSkip)
		{
			return null;
		}

		public Tuple<int, T, TOther> Find2<TOther>(Func<T, TOther, bool> predicate, Vector<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return null;
		}

		public bool Exists(Func<T, bool> predicate, Zeros zeros = Zeros.AllowSkip)
		{
			return false;
		}

		public bool Exists2<TOther>(Func<T, TOther, bool> predicate, Vector<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return false;
		}

		public bool ForAll(Func<T, bool> predicate, Zeros zeros = Zeros.AllowSkip)
		{
			return false;
		}

		public bool ForAll2<TOther>(Func<T, TOther, bool> predicate, Vector<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return false;
		}

		public static Vector<T>operator +(Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator -(Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator +(Vector<T> leftSide, Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator +(Vector<T> leftSide, T rightSide)
		{
			return null;
		}

		public static Vector<T>operator +(T leftSide, Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator -(Vector<T> leftSide, Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator -(Vector<T> leftSide, T rightSide)
		{
			return null;
		}

		public static Vector<T>operator -(T leftSide, Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator *(Vector<T> leftSide, T rightSide)
		{
			return null;
		}

		public static Vector<T>operator *(T leftSide, Vector<T> rightSide)
		{
			return null;
		}

		public static T operator *(Vector<T> leftSide, Vector<T> rightSide)
		{
			return default(T);
		}

		public static Vector<T>operator /(T dividend, Vector<T> divisor)
		{
			return null;
		}

		public static Vector<T>operator /(Vector<T> dividend, T divisor)
		{
			return null;
		}

		public static Vector<T>operator /(Vector<T> dividend, Vector<T> divisor)
		{
			return null;
		}

		public static Vector<T>operator %(Vector<T> dividend, T divisor)
		{
			return null;
		}

		public static Vector<T>operator %(T dividend, Vector<T> divisor)
		{
			return null;
		}

		public static Vector<T>operator %(Vector<T> dividend, Vector<T> divisor)
		{
			return null;
		}

		[SpecialName]
		public static Vector<T> op_DotMultiply(Vector<T> x, Vector<T> y)
		{
			return null;
		}

		[SpecialName]
		public static Vector<T> op_DotDivide(Vector<T> dividend, Vector<T> divisor)
		{
			return null;
		}

		[SpecialName]
		public static Vector<T> op_DotPercent(Vector<T> dividend, Vector<T> divisor)
		{
			return null;
		}

		[SpecialName]
		public static Vector<T> op_DotHat(Vector<T> vector, Vector<T> exponent)
		{
			return null;
		}

		[SpecialName]
		public static Vector<T> op_DotHat(Vector<T> vector, T exponent)
		{
			return null;
		}

		public static Vector<T> Sqrt(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Exp(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Log(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Log10(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Sin(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Cos(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Tan(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Asin(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Acos(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Atan(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Sinh(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Cosh(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Tanh(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Abs(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Floor(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Ceiling(Vector<T> x)
		{
			return null;
		}

		public static Vector<T> Round(Vector<T> x)
		{
			return null;
		}
	}
}
