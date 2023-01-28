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
	public class SparseCompressedRowMatrixStorage<T> : MatrixStorage<T> where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__60 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public SparseCompressedRowMatrixStorage<T> _003C_003E4__this;

			private int _003Ck_003E5__2;

			private int _003Crow_003E5__3;

			private int _003Ccol_003E5__4;

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
			public _003CEnumerate_003Ed__60(int _003C_003E1__state)
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
		private sealed class _003CEnumerateIndexed_003Ed__61 : IEnumerable<(int, int, T)>, IEnumerable, IEnumerator<(int, int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public SparseCompressedRowMatrixStorage<T> _003C_003E4__this;

			private int _003Ck_003E5__2;

			private int _003Crow_003E5__3;

			private int _003Ccol_003E5__4;

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
			public _003CEnumerateIndexed_003Ed__61(int _003C_003E1__state)
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
		private sealed class _003CEnumerateNonZeroIndexed_003Ed__63 : IEnumerable<(int, int, T)>, IEnumerable, IEnumerator<(int, int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public SparseCompressedRowMatrixStorage<T> _003C_003E4__this;

			private int _003Crow_003E5__2;

			private int _003CendIndex_003E5__3;

			private int _003Cj_003E5__4;

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
			public _003CEnumerateNonZeroIndexed_003Ed__63(int _003C_003E1__state)
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
		public readonly int[] RowPointers;

		[DataMember(Order = 2)]
		public int[] ColumnIndices;

		[DataMember(Order = 3)]
		public T[] Values;

		public int ValueCount => 0;

		public override bool IsDense => false;

		public override bool IsFullyMutable => false;

		internal SparseCompressedRowMatrixStorage(int rows, int columns)
		{
			((MatrixStorage<>)(object)this)._002Ector(0, 0);
		}

		internal SparseCompressedRowMatrixStorage(int rows, int columns, int[] rowPointers, int[] columnIndices, T[] values)
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

		private void RemoveAtIndexUnchecked(int itemIndex, int row)
		{
		}

		public int FindItem(int row, int column)
		{
			return 0;
		}

		private int GrowthSize()
		{
			return 0;
		}

		public void Normalize()
		{
		}

		public void NormalizeOrdering()
		{
		}

		public void NormalizeZeros()
		{
		}

		public void NormalizeDuplicates()
		{
		}

		public void PopulateExplicitZerosOnDiagonal()
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

		public static SparseCompressedRowMatrixStorage<T> OfMatrix(MatrixStorage<T> matrix)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfValue(int rows, int columns, T value)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfInit(int rows, int columns, Func<int, int, T> init)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfDiagonalInit(int rows, int columns, Func<int, T> init)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfArray(T[,] array)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfRowArrays(T[][] data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfColumnArrays(T[][] data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfRowVectors(VectorStorage<T>[] data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfColumnVectors(VectorStorage<T>[] data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfIndexedEnumerable(int rows, int columns, IEnumerable<Tuple<int, int, T>> data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfIndexedEnumerable(int rows, int columns, IEnumerable<(int, int, T)> data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfRowEnumerables(int rows, int columns, IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfColumnEnumerables(int rows, int columns, IEnumerable<IEnumerable<T>> data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfRowMajorEnumerable(int rows, int columns, IEnumerable<T> data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfColumnMajorList(int rows, int columns, IList<T> data)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfCompressedSparseRowFormat(int rows, int columns, int valueCount, int[] rowPointers, int[] columnIndices, T[] values)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfCompressedSparseColumnFormat(int rows, int columns, int valueCount, int[] rowIndices, int[] columnPointers, T[] values)
		{
			return null;
		}

		public static SparseCompressedRowMatrixStorage<T> OfCoordinateFormat(int rows, int columns, int valueCount, int[] rowIndices, int[] columnIndices, T[] values)
		{
			return null;
		}

		internal override void CopyToUnchecked(MatrixStorage<T> target, ExistingData existingData)
		{
		}

		private void CopyToUnchecked(SparseCompressedRowMatrixStorage<T> target)
		{
		}

		private void CopyToUnchecked(DenseColumnMajorMatrixStorage<T> target, ExistingData existingData)
		{
		}

		internal override void CopySubMatrixToUnchecked(MatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		private void CopySubMatrixToUnchecked(SparseCompressedRowMatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		internal override void CopySubRowToUnchecked(VectorStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		internal override void TransposeToUnchecked(MatrixStorage<T> target, ExistingData existingData)
		{
		}

		private void TransposeToUnchecked(SparseCompressedRowMatrixStorage<T> target)
		{
		}

		private void TransposeToUnchecked(DenseColumnMajorMatrixStorage<T> target, ExistingData existingData)
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

		[IteratorStateMachine(typeof(SparseCompressedRowMatrixStorage<>._003CEnumerate_003Ed__60))]
		public override IEnumerable<T> Enumerate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(SparseCompressedRowMatrixStorage<>._003CEnumerateIndexed_003Ed__61))]
		public override IEnumerable<(int, int, T)> EnumerateIndexed()
		{
			return null;
		}

		public override IEnumerable<T> EnumerateNonZero()
		{
			return null;
		}

		[IteratorStateMachine(typeof(SparseCompressedRowMatrixStorage<>._003CEnumerateNonZeroIndexed_003Ed__63))]
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

		private void MapSubMatrixIndexedToUnchecked<TU>(SparseCompressedRowMatrixStorage<TU> target, Func<int, int, T, TU> f, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
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
