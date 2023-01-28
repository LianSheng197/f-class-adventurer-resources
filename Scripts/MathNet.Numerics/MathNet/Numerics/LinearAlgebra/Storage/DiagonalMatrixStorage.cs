using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.LinearAlgebra.Storage
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics/LinearAlgebra")]
	public class DiagonalMatrixStorage<T> : MatrixStorage<T> where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__38 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public DiagonalMatrixStorage<T> _003C_003E4__this;

			private int _003Cj_003E5__2;

			private int _003Ci_003E5__3;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CEnumerate_003Ed__38(int _003C_003E1__state)
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
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
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
		private sealed class _003CEnumerateIndexed_003Ed__39 : IEnumerable<(int, int, T)>, IEnumerable, IEnumerator<(int, int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public DiagonalMatrixStorage<T> _003C_003E4__this;

			private int _003Cj_003E5__2;

			private int _003Ci_003E5__3;

			private (int, int, T) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CSystem_002EInt32_002CT_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, int, T));
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
			public _003CEnumerateIndexed_003Ed__39(int _003C_003E1__state)
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
			private IEnumerator<(int, int, T)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CSystem_002EInt32_002CT_0029_003E_002EGetEnumerator()
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
		private sealed class _003CEnumerateNonZeroIndexed_003Ed__41 : IEnumerable<(int, int, T)>, IEnumerable, IEnumerator<(int, int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public DiagonalMatrixStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private (int, int, T) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CSystem_002EInt32_002CT_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, int, T));
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
			public _003CEnumerateNonZeroIndexed_003Ed__41(int _003C_003E1__state)
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
			private IEnumerator<(int, int, T)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CSystem_002EInt32_002CT_0029_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[DataMember(Order = 1)]
		public readonly T[] Data;

		public override bool IsDense => false;

		public override bool IsFullyMutable => false;

		internal DiagonalMatrixStorage(int rows, int columns)
		{
			((MatrixStorage<>)(object)this)._002Ector(0, 0);
		}

		internal DiagonalMatrixStorage(int rows, int columns, T[] data)
		{
			((MatrixStorage<>)(object)this)._002Ector(0, 0);
		}

		public override bool IsMutableAt(int row, int column)
		{
			return false;
		}

		public override T At(int row, int column)
		{
			return default(T);
		}

		public override void At(int row, int column, T value)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override void Clear()
		{
		}

		internal override void ClearUnchecked(int rowIndex, int rowCount, int columnIndex, int columnCount)
		{
		}

		internal override void ClearRowsUnchecked(int[] rowIndices)
		{
		}

		internal override void ClearColumnsUnchecked(int[] columnIndices)
		{
		}

		public static DiagonalMatrixStorage<T> OfMatrix(MatrixStorage<T> matrix)
		{
			return null;
		}

		public static DiagonalMatrixStorage<T> OfArray(T[,] array)
		{
			return null;
		}

		public static DiagonalMatrixStorage<T> OfValue(int rows, int columns, T diagonalValue)
		{
			return null;
		}

		public static DiagonalMatrixStorage<T> OfInit(int rows, int columns, Func<int, T> init)
		{
			return null;
		}

		public static DiagonalMatrixStorage<T> OfEnumerable(int rows, int columns, IEnumerable<T> data)
		{
			return null;
		}

		public static DiagonalMatrixStorage<T> OfIndexedEnumerable(int rows, int columns, IEnumerable<Tuple<int, T>> data)
		{
			return null;
		}

		public static DiagonalMatrixStorage<T> OfIndexedEnumerable(int rows, int columns, IEnumerable<(int, T)> data)
		{
			return null;
		}

		internal override void CopyToUnchecked(MatrixStorage<T> target, ExistingData existingData)
		{
		}

		private void CopyToUnchecked(DiagonalMatrixStorage<T> target)
		{
		}

		private void CopyToUnchecked(SparseCompressedRowMatrixStorage<T> target, ExistingData existingData)
		{
		}

		private void CopyToUnchecked(DenseColumnMajorMatrixStorage<T> target, ExistingData existingData)
		{
		}

		internal override void CopySubMatrixToUnchecked(MatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		private void CopySubMatrixToUnchecked(DiagonalMatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount)
		{
		}

		private void CopySubMatrixToUnchecked(DenseColumnMajorMatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		internal override void CopySubRowToUnchecked(VectorStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		internal override void CopySubColumnToUnchecked(VectorStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount, ExistingData existingData)
		{
		}

		internal override void TransposeToUnchecked(MatrixStorage<T> target, ExistingData existingData)
		{
		}

		internal override void TransposeSquareInplaceUnchecked()
		{
		}

		public override T[] ToRowMajorArray()
		{
			return null;
		}

		public override T[] ToColumnMajorArray()
		{
			return null;
		}

		public override T[][] ToRowArrays()
		{
			return null;
		}

		public override T[][] ToColumnArrays()
		{
			return null;
		}

		public override T[,] ToArray()
		{
			return null;
		}

		[IteratorStateMachine(typeof(DiagonalMatrixStorage<>._003CEnumerate_003Ed__38))]
		public override IEnumerable<T> Enumerate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(DiagonalMatrixStorage<>._003CEnumerateIndexed_003Ed__39))]
		public override IEnumerable<(int, int, T)> EnumerateIndexed()
		{
			return null;
		}

		public override IEnumerable<T> EnumerateNonZero()
		{
			return null;
		}

		[IteratorStateMachine(typeof(DiagonalMatrixStorage<>._003CEnumerateNonZeroIndexed_003Ed__41))]
		public override IEnumerable<(int, int, T)> EnumerateNonZeroIndexed()
		{
			return null;
		}

		public override Tuple<int, int, T> Find(Func<T, bool> predicate, Zeros zeros)
		{
			return null;
		}

		internal override Tuple<int, int, T, TOther> Find2Unchecked<TOther>(MatrixStorage<TOther> other, Func<T, TOther, bool> predicate, Zeros zeros)
		{
			return null;
		}

		public override void MapInplace(Func<T, T> f, Zeros zeros)
		{
		}

		public override void MapIndexedInplace(Func<int, int, T, T> f, Zeros zeros)
		{
		}

		internal override void MapToUnchecked<TU>(MatrixStorage<TU> target, Func<T, TU> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal override void MapIndexedToUnchecked<TU>(MatrixStorage<TU> target, Func<int, int, T, TU> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal override void MapSubMatrixIndexedToUnchecked<TU>(MatrixStorage<TU> target, Func<int, int, T, TU> f, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, Zeros zeros, ExistingData existingData)
		{
		}

		private void MapSubMatrixIndexedToUnchecked<TU>(DiagonalMatrixStorage<TU> target, Func<int, int, T, TU> f, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, Zeros zeros) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		private void MapSubMatrixIndexedToUnchecked<TU>(DenseColumnMajorMatrixStorage<TU> target, Func<int, int, T, TU> f, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		internal override void FoldByRowUnchecked<TU>(TU[] target, Func<TU, T, TU> f, Func<TU, int, TU> finalize, TU[] state, Zeros zeros)
		{
		}

		internal override void FoldByColumnUnchecked<TU>(TU[] target, Func<TU, T, TU> f, Func<TU, int, TU> finalize, TU[] state, Zeros zeros)
		{
		}

		internal override TState Fold2Unchecked<TOther, TState>(MatrixStorage<TOther> other, Func<TState, T, TOther, TState> f, TState state, Zeros zeros)
		{
			return default(TState);
		}
	}
}
