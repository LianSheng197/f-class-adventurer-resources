using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Storage;

namespace MathNet.Numerics.LinearAlgebra
{
	[Serializable]
	[DefaultMember("Item")]
	[DebuggerDisplay("Matrix {RowCount}x{ColumnCount}")]
	public abstract class Matrix<T> : IFormattable, IEquatable<Matrix<T>>, ICloneable where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerateColumns_003Ed__315 : IEnumerable<Vector<T>>, IEnumerable, IEnumerator<Vector<T>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Vector<T> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Matrix<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private Vector<T> System_002ECollections_002EGeneric_002EIEnumerator_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateColumns_003Ed__315(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Vector<T>> System_002ECollections_002EGeneric_002EIEnumerable_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateColumns_003Ed__316 : IEnumerable<Vector<T>>, IEnumerable, IEnumerator<Vector<T>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Vector<T> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int index;

			public int _003C_003E3__index;

			private int length;

			public int _003C_003E3__length;

			public Matrix<T> _003C_003E4__this;

			private int _003CmaxIndex_003E5__2;

			private int _003Ci_003E5__3;

			private Vector<T> System_002ECollections_002EGeneric_002EIEnumerator_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateColumns_003Ed__316(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Vector<T>> System_002ECollections_002EGeneric_002EIEnumerable_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateColumnsIndexed_003Ed__317 : IEnumerable<(int, Vector<T>)>, IEnumerable, IEnumerator<(int, Vector<T>)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, Vector<T>) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Matrix<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private (int, Vector<T>) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, Vector<T>));
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateColumnsIndexed_003Ed__317(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<(int, Vector<T>)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateColumnsIndexed_003Ed__318 : IEnumerable<(int, Vector<T>)>, IEnumerable, IEnumerator<(int, Vector<T>)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, Vector<T>) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int index;

			public int _003C_003E3__index;

			private int length;

			public int _003C_003E3__length;

			public Matrix<T> _003C_003E4__this;

			private int _003CmaxIndex_003E5__2;

			private int _003Ci_003E5__3;

			private (int, Vector<T>) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, Vector<T>));
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateColumnsIndexed_003Ed__318(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<(int, Vector<T>)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateRows_003Ed__319 : IEnumerable<Vector<T>>, IEnumerable, IEnumerator<Vector<T>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Vector<T> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Matrix<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private Vector<T> System_002ECollections_002EGeneric_002EIEnumerator_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateRows_003Ed__319(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Vector<T>> System_002ECollections_002EGeneric_002EIEnumerable_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateRows_003Ed__320 : IEnumerable<Vector<T>>, IEnumerable, IEnumerator<Vector<T>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Vector<T> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int index;

			public int _003C_003E3__index;

			private int length;

			public int _003C_003E3__length;

			public Matrix<T> _003C_003E4__this;

			private int _003CmaxIndex_003E5__2;

			private int _003Ci_003E5__3;

			private Vector<T> System_002ECollections_002EGeneric_002EIEnumerator_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateRows_003Ed__320(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<Vector<T>> System_002ECollections_002EGeneric_002EIEnumerable_003CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateRowsIndexed_003Ed__321 : IEnumerable<(int, Vector<T>)>, IEnumerable, IEnumerator<(int, Vector<T>)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, Vector<T>) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Matrix<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private (int, Vector<T>) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, Vector<T>));
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateRowsIndexed_003Ed__321(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<(int, Vector<T>)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnumerateRowsIndexed_003Ed__322 : IEnumerable<(int, Vector<T>)>, IEnumerable, IEnumerator<(int, Vector<T>)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, Vector<T>) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int index;

			public int _003C_003E3__index;

			private int length;

			public int _003C_003E3__length;

			public Matrix<T> _003C_003E4__this;

			private int _003CmaxIndex_003E5__2;

			private int _003Ci_003E5__3;

			private (int, Vector<T>) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, Vector<T>));
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CEnumerateRowsIndexed_003Ed__322(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<(int, Vector<T>)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CMathNet_002ENumerics_002ELinearAlgebra_002EVector_003CT_003E_0029_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public static readonly T One;

		public static readonly T Zero;

		public static readonly MatrixBuilder<T> Build;

		public MatrixStorage<T> Storage
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

		public int ColumnCount
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

		public int RowCount
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

		protected abstract void DoNegate(Matrix<T> result);

		protected abstract void DoConjugate(Matrix<T> result);

		protected abstract void DoAdd(T scalar, Matrix<T> result);

		protected abstract void DoAdd(Matrix<T> other, Matrix<T> result);

		protected abstract void DoSubtract(T scalar, Matrix<T> result);

		protected void DoSubtractFrom(T scalar, Matrix<T> result)
		{
		}

		protected abstract void DoSubtract(Matrix<T> other, Matrix<T> result);

		protected abstract void DoMultiply(T scalar, Matrix<T> result);

		protected abstract void DoMultiply(Vector<T> rightSide, Vector<T> result);

		protected abstract void DoMultiply(Matrix<T> other, Matrix<T> result);

		protected abstract void DoTransposeAndMultiply(Matrix<T> other, Matrix<T> result);

		protected abstract void DoConjugateTransposeAndMultiply(Matrix<T> other, Matrix<T> result);

		protected abstract void DoTransposeThisAndMultiply(Vector<T> rightSide, Vector<T> result);

		protected abstract void DoConjugateTransposeThisAndMultiply(Vector<T> rightSide, Vector<T> result);

		protected abstract void DoTransposeThisAndMultiply(Matrix<T> other, Matrix<T> result);

		protected abstract void DoConjugateTransposeThisAndMultiply(Matrix<T> other, Matrix<T> result);

		protected abstract void DoDivide(T divisor, Matrix<T> result);

		protected abstract void DoDivideByThis(T dividend, Matrix<T> result);

		protected abstract void DoModulus(T divisor, Matrix<T> result);

		protected abstract void DoModulusByThis(T dividend, Matrix<T> result);

		protected abstract void DoRemainder(T divisor, Matrix<T> result);

		protected abstract void DoRemainderByThis(T dividend, Matrix<T> result);

		protected abstract void DoPointwiseMultiply(Matrix<T> other, Matrix<T> result);

		protected abstract void DoPointwiseDivide(Matrix<T> divisor, Matrix<T> result);

		protected abstract void DoPointwisePower(T exponent, Matrix<T> result);

		protected abstract void DoPointwisePower(Matrix<T> exponent, Matrix<T> result);

		protected abstract void DoPointwiseModulus(Matrix<T> divisor, Matrix<T> result);

		protected abstract void DoPointwiseRemainder(Matrix<T> divisor, Matrix<T> result);

		protected abstract void DoPointwiseExp(Matrix<T> result);

		protected abstract void DoPointwiseLog(Matrix<T> result);

		protected abstract void DoPointwiseAbs(Matrix<T> result);

		protected abstract void DoPointwiseAcos(Matrix<T> result);

		protected abstract void DoPointwiseAsin(Matrix<T> result);

		protected abstract void DoPointwiseAtan(Matrix<T> result);

		protected abstract void DoPointwiseCeiling(Matrix<T> result);

		protected abstract void DoPointwiseCos(Matrix<T> result);

		protected abstract void DoPointwiseCosh(Matrix<T> result);

		protected abstract void DoPointwiseFloor(Matrix<T> result);

		protected abstract void DoPointwiseLog10(Matrix<T> result);

		protected abstract void DoPointwiseRound(Matrix<T> result);

		protected abstract void DoPointwiseSign(Matrix<T> result);

		protected abstract void DoPointwiseSin(Matrix<T> result);

		protected abstract void DoPointwiseSinh(Matrix<T> result);

		protected abstract void DoPointwiseSqrt(Matrix<T> result);

		protected abstract void DoPointwiseTan(Matrix<T> result);

		protected abstract void DoPointwiseTanh(Matrix<T> result);

		protected abstract void DoPointwiseAtan2(Matrix<T> other, Matrix<T> result);

		protected abstract void DoPointwiseMinimum(T scalar, Matrix<T> result);

		protected abstract void DoPointwiseMinimum(Matrix<T> other, Matrix<T> result);

		protected abstract void DoPointwiseMaximum(T scalar, Matrix<T> result);

		protected abstract void DoPointwiseMaximum(Matrix<T> other, Matrix<T> result);

		protected abstract void DoPointwiseAbsoluteMinimum(T scalar, Matrix<T> result);

		protected abstract void DoPointwiseAbsoluteMinimum(Matrix<T> other, Matrix<T> result);

		protected abstract void DoPointwiseAbsoluteMaximum(T scalar, Matrix<T> result);

		protected abstract void DoPointwiseAbsoluteMaximum(Matrix<T> other, Matrix<T> result);

		public Matrix<T> Add(T scalar)
		{
			return null;
		}

		public void Add(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> Add(Matrix<T> other)
		{
			return null;
		}

		public void Add(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> Subtract(T scalar)
		{
			return null;
		}

		public void Subtract(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> SubtractFrom(T scalar)
		{
			return null;
		}

		public void SubtractFrom(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> Subtract(Matrix<T> other)
		{
			return null;
		}

		public void Subtract(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> Multiply(T scalar)
		{
			return null;
		}

		public void Multiply(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> Divide(T scalar)
		{
			return null;
		}

		public void Divide(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> DivideByThis(T scalar)
		{
			return null;
		}

		public void DivideByThis(T scalar, Matrix<T> result)
		{
		}

		public Vector<T> Multiply(Vector<T> rightSide)
		{
			return null;
		}

		public void Multiply(Vector<T> rightSide, Vector<T> result)
		{
		}

		public Vector<T> LeftMultiply(Vector<T> leftSide)
		{
			return null;
		}

		public void LeftMultiply(Vector<T> leftSide, Vector<T> result)
		{
		}

		protected void DoLeftMultiply(Vector<T> leftSide, Vector<T> result)
		{
		}

		public void Multiply(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> Multiply(Matrix<T> other)
		{
			return null;
		}

		public void TransposeAndMultiply(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> TransposeAndMultiply(Matrix<T> other)
		{
			return null;
		}

		public Vector<T> TransposeThisAndMultiply(Vector<T> rightSide)
		{
			return null;
		}

		public void TransposeThisAndMultiply(Vector<T> rightSide, Vector<T> result)
		{
		}

		public void TransposeThisAndMultiply(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> TransposeThisAndMultiply(Matrix<T> other)
		{
			return null;
		}

		public void ConjugateTransposeAndMultiply(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> ConjugateTransposeAndMultiply(Matrix<T> other)
		{
			return null;
		}

		public Vector<T> ConjugateTransposeThisAndMultiply(Vector<T> rightSide)
		{
			return null;
		}

		public void ConjugateTransposeThisAndMultiply(Vector<T> rightSide, Vector<T> result)
		{
		}

		public void ConjugateTransposeThisAndMultiply(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> ConjugateTransposeThisAndMultiply(Matrix<T> other)
		{
			return null;
		}

		private static Matrix<T> IntPower(int exponent, Matrix<T> x, Matrix<T> y, Matrix<T> work)
		{
			return null;
		}

		public void Power(int exponent, Matrix<T> result)
		{
		}

		public Matrix<T> Power(int exponent)
		{
			return null;
		}

		public Matrix<T> Negate()
		{
			return null;
		}

		public void Negate(Matrix<T> result)
		{
		}

		public Matrix<T> Conjugate()
		{
			return null;
		}

		public void Conjugate(Matrix<T> result)
		{
		}

		public Matrix<T> Modulus(T divisor)
		{
			return null;
		}

		public void Modulus(T divisor, Matrix<T> result)
		{
		}

		public Matrix<T> ModulusByThis(T dividend)
		{
			return null;
		}

		public void ModulusByThis(T dividend, Matrix<T> result)
		{
		}

		public Matrix<T> Remainder(T divisor)
		{
			return null;
		}

		public void Remainder(T divisor, Matrix<T> result)
		{
		}

		public Matrix<T> RemainderByThis(T dividend)
		{
			return null;
		}

		public void RemainderByThis(T dividend, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseMultiply(Matrix<T> other)
		{
			return null;
		}

		public void PointwiseMultiply(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseDivide(Matrix<T> divisor)
		{
			return null;
		}

		public void PointwiseDivide(Matrix<T> divisor, Matrix<T> result)
		{
		}

		public Matrix<T> PointwisePower(T exponent)
		{
			return null;
		}

		public void PointwisePower(T exponent, Matrix<T> result)
		{
		}

		public Matrix<T> PointwisePower(Matrix<T> exponent)
		{
			return null;
		}

		public void PointwisePower(Matrix<T> exponent, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseModulus(Matrix<T> divisor)
		{
			return null;
		}

		public void PointwiseModulus(Matrix<T> divisor, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseRemainder(Matrix<T> divisor)
		{
			return null;
		}

		public void PointwiseRemainder(Matrix<T> divisor, Matrix<T> result)
		{
		}

		protected Matrix<T> PointwiseUnary(Action<Matrix<T>> f)
		{
			return null;
		}

		protected void PointwiseUnary(Action<Matrix<T>> f, Matrix<T> result)
		{
		}

		protected Matrix<T> PointwiseBinary(Action<Matrix<T>, Matrix<T>> f, Matrix<T> other)
		{
			return null;
		}

		protected void PointwiseBinary(Action<Matrix<T>, Matrix<T>> f, Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseExp()
		{
			return null;
		}

		public void PointwiseExp(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseLog()
		{
			return null;
		}

		public void PointwiseLog(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAbs()
		{
			return null;
		}

		public void PointwiseAbs(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAcos()
		{
			return null;
		}

		public void PointwiseAcos(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAsin()
		{
			return null;
		}

		public void PointwiseAsin(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAtan()
		{
			return null;
		}

		public void PointwiseAtan(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAtan2(Matrix<T> other)
		{
			return null;
		}

		public void PointwiseAtan2(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseCeiling()
		{
			return null;
		}

		public void PointwiseCeiling(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseCos()
		{
			return null;
		}

		public void PointwiseCos(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseCosh()
		{
			return null;
		}

		public void PointwiseCosh(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseFloor()
		{
			return null;
		}

		public void PointwiseFloor(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseLog10()
		{
			return null;
		}

		public void PointwiseLog10(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseRound()
		{
			return null;
		}

		public void PointwiseRound(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseSign()
		{
			return null;
		}

		public void PointwiseSign(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseSin()
		{
			return null;
		}

		public void PointwiseSin(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseSinh()
		{
			return null;
		}

		public void PointwiseSinh(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseSqrt()
		{
			return null;
		}

		public void PointwiseSqrt(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseTan()
		{
			return null;
		}

		public void PointwiseTan(Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseTanh()
		{
			return null;
		}

		public void PointwiseTanh(Matrix<T> result)
		{
		}

		public abstract T Trace();

		public virtual int Rank()
		{
			return 0;
		}

		public int Nullity()
		{
			return 0;
		}

		public virtual T ConditionNumber()
		{
			return default(T);
		}

		public virtual T Determinant()
		{
			return default(T);
		}

		public virtual Vector<T>[] Kernel()
		{
			return null;
		}

		public virtual Vector<T>[] Range()
		{
			return null;
		}

		public virtual Matrix<T> Inverse()
		{
			return null;
		}

		public abstract Matrix<T> PseudoInverse();

		public Matrix<T> KroneckerProduct(Matrix<T> other)
		{
			return null;
		}

		public virtual void KroneckerProduct(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseMinimum(T scalar)
		{
			return null;
		}

		public void PointwiseMinimum(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseMaximum(T scalar)
		{
			return null;
		}

		public void PointwiseMaximum(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAbsoluteMinimum(T scalar)
		{
			return null;
		}

		public void PointwiseAbsoluteMinimum(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAbsoluteMaximum(T scalar)
		{
			return null;
		}

		public void PointwiseAbsoluteMaximum(T scalar, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseMinimum(Matrix<T> other)
		{
			return null;
		}

		public void PointwiseMinimum(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseMaximum(Matrix<T> other)
		{
			return null;
		}

		public void PointwiseMaximum(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAbsoluteMinimum(Matrix<T> other)
		{
			return null;
		}

		public void PointwiseAbsoluteMinimum(Matrix<T> other, Matrix<T> result)
		{
		}

		public Matrix<T> PointwiseAbsoluteMaximum(Matrix<T> other)
		{
			return null;
		}

		public void PointwiseAbsoluteMaximum(Matrix<T> other, Matrix<T> result)
		{
		}

		public abstract double L1Norm();

		public virtual double L2Norm()
		{
			return 0.0;
		}

		public abstract double InfinityNorm();

		public abstract double FrobeniusNorm();

		public abstract Vector<double> RowNorms(double norm);

		public abstract Vector<double> ColumnNorms(double norm);

		public abstract Matrix<T> NormalizeRows(double norm);

		public abstract Matrix<T> NormalizeColumns(double norm);

		public abstract Vector<T> RowSums();

		public abstract Vector<T> ColumnSums();

		public abstract Vector<T> RowAbsoluteSums();

		public abstract Vector<T> ColumnAbsoluteSums();

		internal static Exception DimensionsDontMatch<TException>(Matrix<T> left, Matrix<T> right, Matrix<T> result, string paramName = null) where TException : Exception
		{
			return null;
		}

		internal static Exception DimensionsDontMatch<TException>(Matrix<T> left, Matrix<T> right, string paramName = null) where TException : Exception
		{
			return null;
		}

		internal static Exception DimensionsDontMatch<TException>(Matrix<T> matrix) where TException : Exception
		{
			return null;
		}

		internal static Exception DimensionsDontMatch<TException>(Matrix<T> left, Vector<T> right, Vector<T> result, string paramName = null) where TException : Exception
		{
			return null;
		}

		internal static Exception DimensionsDontMatch<TException>(Matrix<T> left, Vector<T> right, string paramName = null) where TException : Exception
		{
			return null;
		}

		internal static Exception DimensionsDontMatch<TException>(Vector<T> left, Matrix<T> right, string paramName = null) where TException : Exception
		{
			return null;
		}

		internal static Exception DimensionsDontMatch<TException>(Vector<T> left, Vector<T> right, string paramName = null) where TException : Exception
		{
			return null;
		}

		private static Exception CreateException<TException>(string message, string paramName = null) where TException : Exception
		{
			return null;
		}

		public bool Equals(Matrix<T> other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private object System_002EICloneable_002EClone()
		{
			return null;
		}

		public virtual string ToTypeString()
		{
			return null;
		}

		public string[,] ToMatrixStringArray(int upperRows, int lowerRows, int leftColumns, int rightColumns, string horizontalEllipsis, string verticalEllipsis, string diagonalEllipsis, Func<T, string> formatValue)
		{
			return null;
		}

		public string[,] ToMatrixStringArray(int upperRows, int lowerRows, int minLeftColumns, int rightColumns, int maxWidth, int padding, string horizontalEllipsis, string verticalEllipsis, string diagonalEllipsis, Func<T, string> formatValue)
		{
			return null;
		}

		private Tuple<int, string[]> FormatColumn(int column, int height, int upper, int lower, bool withEllipsis, string ellipsis, Func<T, string> formatValue)
		{
			return null;
		}

		private static string FormatStringArrayToString(string[,] array, string columnSeparator, string rowSeparator)
		{
			return null;
		}

		public string ToMatrixString(int upperRows, int lowerRows, int leftColumns, int rightColumns, string horizontalEllipsis, string verticalEllipsis, string diagonalEllipsis, string columnSeparator, string rowSeparator, Func<T, string> formatValue)
		{
			return null;
		}

		public string ToMatrixString(int upperRows, int lowerRows, int minLeftColumns, int rightColumns, int maxWidth, string horizontalEllipsis, string verticalEllipsis, string diagonalEllipsis, string columnSeparator, string rowSeparator, Func<T, string> formatValue)
		{
			return null;
		}

		public string ToMatrixString(int maxRows, int maxColumns, string format = null, IFormatProvider provider = null)
		{
			return null;
		}

		public string ToMatrixString(string format = null, IFormatProvider provider = null)
		{
			return null;
		}

		public string ToString(int maxRows, int maxColumns, string format = null, IFormatProvider formatProvider = null)
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

		protected Matrix(MatrixStorage<T> storage)
		{
		}

		[MethodImpl(256)]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public T At(int row, int column)
		{
			return default(T);
		}

		[MethodImpl(256)]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public void At(int row, int column, T value)
		{
		}

		public void Clear()
		{
		}

		public void ClearRow(int rowIndex)
		{
		}

		public void ClearColumn(int columnIndex)
		{
		}

		public void ClearRows(params int[] rowIndices)
		{
		}

		public void ClearColumns(params int[] columnIndices)
		{
		}

		public void ClearSubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount)
		{
		}

		public abstract void CoerceZero(double threshold);

		public void CoerceZero(Func<T, bool> zeroPredicate)
		{
		}

		public Matrix<T> Clone()
		{
			return null;
		}

		public void CopyTo(Matrix<T> target)
		{
		}

		public Vector<T> Row(int index)
		{
			return null;
		}

		public void Row(int index, Vector<T> result)
		{
		}

		public Vector<T> Row(int rowIndex, int columnIndex, int length)
		{
			return null;
		}

		public void Row(int rowIndex, int columnIndex, int length, Vector<T> result)
		{
		}

		public Vector<T> Column(int index)
		{
			return null;
		}

		public void Column(int index, Vector<T> result)
		{
		}

		public Vector<T> Column(int columnIndex, int rowIndex, int length)
		{
			return null;
		}

		public void Column(int columnIndex, int rowIndex, int length, Vector<T> result)
		{
		}

		public virtual Matrix<T> UpperTriangle()
		{
			return null;
		}

		public virtual Matrix<T> LowerTriangle()
		{
			return null;
		}

		public virtual void LowerTriangle(Matrix<T> result)
		{
		}

		public virtual void UpperTriangle(Matrix<T> result)
		{
		}

		public virtual Matrix<T> SubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount)
		{
			return null;
		}

		public virtual Vector<T> Diagonal()
		{
			return null;
		}

		public virtual Matrix<T> StrictlyLowerTriangle()
		{
			return null;
		}

		public virtual void StrictlyLowerTriangle(Matrix<T> result)
		{
		}

		public virtual Matrix<T> StrictlyUpperTriangle()
		{
			return null;
		}

		public virtual void StrictlyUpperTriangle(Matrix<T> result)
		{
		}

		public Matrix<T> InsertColumn(int columnIndex, Vector<T> column)
		{
			return null;
		}

		public Matrix<T> RemoveColumn(int columnIndex)
		{
			return null;
		}

		public void SetColumn(int columnIndex, Vector<T> column)
		{
		}

		public void SetColumn(int columnIndex, int rowIndex, int length, Vector<T> column)
		{
		}

		public void SetColumn(int columnIndex, T[] column)
		{
		}

		public Matrix<T> InsertRow(int rowIndex, Vector<T> row)
		{
			return null;
		}

		public Matrix<T> RemoveRow(int rowIndex)
		{
			return null;
		}

		public void SetRow(int rowIndex, Vector<T> row)
		{
		}

		public void SetRow(int rowIndex, int columnIndex, int length, Vector<T> row)
		{
		}

		public void SetRow(int rowIndex, T[] row)
		{
		}

		public void SetSubMatrix(int rowIndex, int columnIndex, Matrix<T> subMatrix)
		{
		}

		public void SetSubMatrix(int rowIndex, int rowCount, int columnIndex, int columnCount, Matrix<T> subMatrix)
		{
		}

		public void SetSubMatrix(int rowIndex, int sorceRowIndex, int rowCount, int columnIndex, int sourceColumnIndex, int columnCount, Matrix<T> subMatrix)
		{
		}

		public virtual void SetDiagonal(Vector<T> source)
		{
		}

		public virtual void SetDiagonal(T[] source)
		{
		}

		public Matrix<T> Resize(int rowCount, int columnCount)
		{
			return null;
		}

		public Matrix<T> Transpose()
		{
			return null;
		}

		public void Transpose(Matrix<T> result)
		{
		}

		public abstract Matrix<T> ConjugateTranspose();

		public abstract void ConjugateTranspose(Matrix<T> result);

		public virtual void PermuteRows(Permutation p)
		{
		}

		public virtual void PermuteColumns(Permutation p)
		{
		}

		public Matrix<T> Append(Matrix<T> right)
		{
			return null;
		}

		public void Append(Matrix<T> right, Matrix<T> result)
		{
		}

		public Matrix<T> Stack(Matrix<T> lower)
		{
			return null;
		}

		public void Stack(Matrix<T> lower, Matrix<T> result)
		{
		}

		public Matrix<T> DiagonalStack(Matrix<T> lower)
		{
			return null;
		}

		public void DiagonalStack(Matrix<T> lower, Matrix<T> result)
		{
		}

		public virtual bool IsSymmetric()
		{
			return false;
		}

		public abstract bool IsHermitian();

		public T[,] ToArray()
		{
			return null;
		}

		public T[] ToColumnMajorArray()
		{
			return null;
		}

		public T[] ToRowMajorArray()
		{
			return null;
		}

		public T[][] ToRowArrays()
		{
			return null;
		}

		public T[][] ToColumnArrays()
		{
			return null;
		}

		public T[,] AsArray()
		{
			return null;
		}

		public T[] AsColumnMajorArray()
		{
			return null;
		}

		public T[] AsRowMajorArray()
		{
			return null;
		}

		public T[][] AsRowArrays()
		{
			return null;
		}

		public T[][] AsColumnArrays()
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

		public IEnumerable<(int, int, T)> EnumerateIndexed()
		{
			return null;
		}

		public IEnumerable<(int, int, T)> EnumerateIndexed(Zeros zeros)
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateColumns_003Ed__315))]
		public IEnumerable<Vector<T>> EnumerateColumns()
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateColumns_003Ed__316))]
		public IEnumerable<Vector<T>> EnumerateColumns(int index, int length)
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateColumnsIndexed_003Ed__317))]
		public IEnumerable<(int, Vector<T>)> EnumerateColumnsIndexed()
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateColumnsIndexed_003Ed__318))]
		public IEnumerable<(int, Vector<T>)> EnumerateColumnsIndexed(int index, int length)
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateRows_003Ed__319))]
		public IEnumerable<Vector<T>> EnumerateRows()
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateRows_003Ed__320))]
		public IEnumerable<Vector<T>> EnumerateRows(int index, int length)
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateRowsIndexed_003Ed__321))]
		public IEnumerable<(int, Vector<T>)> EnumerateRowsIndexed()
		{
			return null;
		}

		[IteratorStateMachine(typeof(Matrix<>._003CEnumerateRowsIndexed_003Ed__322))]
		public IEnumerable<(int, Vector<T>)> EnumerateRowsIndexed(int index, int length)
		{
			return null;
		}

		public void MapInplace(Func<T, T> f, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void MapIndexedInplace(Func<int, int, T, T> f, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void Map(Func<T, T> f, Matrix<T> result, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void MapIndexed(Func<int, int, T, T> f, Matrix<T> result, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public void MapConvert<TU>(Func<T, TU> f, Matrix<TU> result, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void MapIndexedConvert<TU>(Func<int, int, T, TU> f, Matrix<TU> result, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public Matrix<TU> Map<TU>(Func<T, TU> f, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Matrix<TU> MapIndexed<TU>(Func<int, int, T, TU> f, Zeros zeros = Zeros.AllowSkip) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public TU[] FoldByRow<TU>(Func<TU, T, TU> f, TU state, Zeros zeros = Zeros.AllowSkip)
		{
			return null;
		}

		public TU[] FoldByColumn<TU>(Func<TU, T, TU> f, TU state, Zeros zeros = Zeros.AllowSkip)
		{
			return null;
		}

		public Vector<TU> FoldRows<TU>(Func<Vector<TU>, Vector<T>, Vector<TU>> f, Vector<TU> state) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Vector<TU> FoldColumns<TU>(Func<Vector<TU>, Vector<T>, Vector<TU>> f, Vector<TU> state) where TU : struct, IEquatable<TU>, IFormattable
		{
			return null;
		}

		public Vector<T> ReduceRows(Func<Vector<T>, Vector<T>, Vector<T>> f)
		{
			return null;
		}

		public Vector<T> ReduceColumns(Func<Vector<T>, Vector<T>, Vector<T>> f)
		{
			return null;
		}

		public void Map2(Func<T, T, T> f, Matrix<T> other, Matrix<T> result, Zeros zeros = Zeros.AllowSkip)
		{
		}

		public Matrix<T> Map2(Func<T, T, T> f, Matrix<T> other, Zeros zeros = Zeros.AllowSkip)
		{
			return null;
		}

		public TState Fold2<TOther, TState>(Func<TState, T, TOther, TState> f, TState state, Matrix<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return default(TState);
		}

		public Tuple<int, int, T> Find(Func<T, bool> predicate, Zeros zeros = Zeros.AllowSkip)
		{
			return null;
		}

		public Tuple<int, int, T, TOther> Find2<TOther>(Func<T, TOther, bool> predicate, Matrix<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return null;
		}

		public bool Exists(Func<T, bool> predicate, Zeros zeros = Zeros.AllowSkip)
		{
			return false;
		}

		public bool Exists2<TOther>(Func<T, TOther, bool> predicate, Matrix<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return false;
		}

		public bool ForAll(Func<T, bool> predicate, Zeros zeros = Zeros.AllowSkip)
		{
			return false;
		}

		public bool ForAll2<TOther>(Func<T, TOther, bool> predicate, Matrix<TOther> other, Zeros zeros = Zeros.AllowSkip) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return false;
		}

		public static Matrix<T>operator +(Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator -(Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator +(Matrix<T> leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator +(Matrix<T> leftSide, T rightSide)
		{
			return null;
		}

		public static Matrix<T>operator +(T leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator -(Matrix<T> leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator -(Matrix<T> leftSide, T rightSide)
		{
			return null;
		}

		public static Matrix<T>operator -(T leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator *(Matrix<T> leftSide, T rightSide)
		{
			return null;
		}

		public static Matrix<T>operator *(T leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator *(Matrix<T> leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator *(Matrix<T> leftSide, Vector<T> rightSide)
		{
			return null;
		}

		public static Vector<T>operator *(Vector<T> leftSide, Matrix<T> rightSide)
		{
			return null;
		}

		public static Matrix<T>operator /(T dividend, Matrix<T> divisor)
		{
			return null;
		}

		public static Matrix<T>operator /(Matrix<T> dividend, T divisor)
		{
			return null;
		}

		public static Matrix<T>operator %(Matrix<T> dividend, T divisor)
		{
			return null;
		}

		public static Matrix<T>operator %(T dividend, Matrix<T> divisor)
		{
			return null;
		}

		public static Matrix<T>operator %(Matrix<T> dividend, Matrix<T> divisor)
		{
			return null;
		}

		[SpecialName]
		public static Matrix<T> op_DotMultiply(Matrix<T> x, Matrix<T> y)
		{
			return null;
		}

		[SpecialName]
		public static Matrix<T> op_DotDivide(Matrix<T> dividend, Matrix<T> divisor)
		{
			return null;
		}

		[SpecialName]
		public static Matrix<T> op_DotPercent(Matrix<T> dividend, Matrix<T> divisor)
		{
			return null;
		}

		[SpecialName]
		public static Matrix<T> op_DotHat(Matrix<T> matrix, Matrix<T> exponent)
		{
			return null;
		}

		[SpecialName]
		public static Matrix<T> op_DotHat(Matrix<T> matrix, T exponent)
		{
			return null;
		}

		public static Matrix<T> Sqrt(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Exp(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Log(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Log10(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Sin(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Cos(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Tan(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Asin(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Acos(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Atan(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Sinh(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Cosh(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Tanh(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Abs(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Floor(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Ceiling(Matrix<T> x)
		{
			return null;
		}

		public static Matrix<T> Round(Matrix<T> x)
		{
			return null;
		}

		public abstract Cholesky<T> Cholesky();

		public abstract LU<T> LU();

		public abstract QR<T> QR(QRMethod method = QRMethod.Thin);

		public abstract GramSchmidt<T> GramSchmidt();

		public abstract Svd<T> Svd(bool computeVectors = true);

		public abstract Evd<T> Evd(Symmetricity symmetricity = Symmetricity.Unknown);

		public void Solve(Vector<T> input, Vector<T> result)
		{
		}

		public void Solve(Matrix<T> input, Matrix<T> result)
		{
		}

		public Matrix<T> Solve(Matrix<T> input)
		{
			return null;
		}

		public Vector<T> Solve(Vector<T> input)
		{
			return null;
		}

		public IterationStatus TrySolveIterative(Vector<T> input, Vector<T> result, IIterativeSolver<T> solver, Iterator<T> iterator = null, IPreconditioner<T> preconditioner = null)
		{
			return default(IterationStatus);
		}

		public IterationStatus TrySolveIterative(Matrix<T> input, Matrix<T> result, IIterativeSolver<T> solver, Iterator<T> iterator = null, IPreconditioner<T> preconditioner = null)
		{
			return default(IterationStatus);
		}

		public IterationStatus TrySolveIterative(Vector<T> input, Vector<T> result, IIterativeSolver<T> solver, IPreconditioner<T> preconditioner, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return default(IterationStatus);
		}

		public IterationStatus TrySolveIterative(Matrix<T> input, Matrix<T> result, IIterativeSolver<T> solver, IPreconditioner<T> preconditioner, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return default(IterationStatus);
		}

		public IterationStatus TrySolveIterative(Vector<T> input, Vector<T> result, IIterativeSolver<T> solver, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return default(IterationStatus);
		}

		public IterationStatus TrySolveIterative(Matrix<T> input, Matrix<T> result, IIterativeSolver<T> solver, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return default(IterationStatus);
		}

		public Vector<T> SolveIterative(Vector<T> input, IIterativeSolver<T> solver, Iterator<T> iterator = null, IPreconditioner<T> preconditioner = null)
		{
			return null;
		}

		public Matrix<T> SolveIterative(Matrix<T> input, IIterativeSolver<T> solver, Iterator<T> iterator = null, IPreconditioner<T> preconditioner = null)
		{
			return null;
		}

		public Vector<T> SolveIterative(Vector<T> input, IIterativeSolver<T> solver, IPreconditioner<T> preconditioner, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return null;
		}

		public Matrix<T> SolveIterative(Matrix<T> input, IIterativeSolver<T> solver, IPreconditioner<T> preconditioner, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return null;
		}

		public Vector<T> SolveIterative(Vector<T> input, IIterativeSolver<T> solver, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return null;
		}

		public Matrix<T> SolveIterative(Matrix<T> input, IIterativeSolver<T> solver, params IIterationStopCriterion<T>[] stopCriteria)
		{
			return null;
		}
	}
}
