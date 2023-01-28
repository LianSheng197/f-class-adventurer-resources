using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.LinearAlgebra.Storage
{
	[Serializable]
	[DefaultMember("Item")]
	[DataContract(Namespace = "urn:MathNet/Numerics/LinearAlgebra")]
	public abstract class MatrixStorage<T> : IEquatable<MatrixStorage<T>> where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__47 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MatrixStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003Cj_003E5__3;

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
			public _003CEnumerate_003Ed__47(int _003C_003E1__state)
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
		private sealed class _003CEnumerateIndexed_003Ed__48 : IEnumerable<(int, int, T)>, IEnumerable, IEnumerator<(int, int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MatrixStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003Cj_003E5__3;

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
			public _003CEnumerateIndexed_003Ed__48(int _003C_003E1__state)
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
		private sealed class _003CEnumerateNonZero_003Ed__49 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MatrixStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003Cj_003E5__3;

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
			public _003CEnumerateNonZero_003Ed__49(int _003C_003E1__state)
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
		private sealed class _003CEnumerateNonZeroIndexed_003Ed__50 : IEnumerable<(int, int, T)>, IEnumerable, IEnumerator<(int, int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MatrixStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003Cj_003E5__3;

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
			public _003CEnumerateNonZeroIndexed_003Ed__50(int _003C_003E1__state)
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

		protected static readonly T Zero;

		[DataMember(Order = 1)]
		public readonly int RowCount;

		[DataMember(Order = 2)]
		public readonly int ColumnCount;

		public abstract bool IsDense { get; }

		public abstract bool IsFullyMutable { get; }

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		protected MatrixStorage(int rowCount, int columnCount)
		{
		}

		public abstract bool IsMutableAt(int row, int column);

		public abstract T At(int row, int column);

		public abstract void At(int row, int column, T value);

		public bool Equals(MatrixStorage<T> other)
		{
			return false;
		}

		public sealed override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public virtual void Clear()
		{
		}

		public void Clear(int rowIndex, int rowCount, int columnIndex, int columnCount)
		{
		}

		internal virtual void ClearUnchecked(int rowIndex, int rowCount, int columnIndex, int columnCount)
		{
		}

		public void ClearRows(int[] rowIndices)
		{
		}

		public void ClearColumns(int[] columnIndices)
		{
		}

		internal virtual void ClearRowsUnchecked(int[] rowIndices)
		{
		}

		internal virtual void ClearColumnsUnchecked(int[] columnIndices)
		{
		}

		public void CopyTo(MatrixStorage<T> target, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopyToUnchecked(MatrixStorage<T> target, ExistingData existingData)
		{
		}

		public void CopySubMatrixTo(MatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopySubMatrixToUnchecked(MatrixStorage<T> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		public void CopyRowTo(VectorStorage<T> target, int rowIndex, ExistingData existingData = ExistingData.Clear)
		{
		}

		public void CopySubRowTo(VectorStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopySubRowToUnchecked(VectorStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		public void CopyColumnTo(VectorStorage<T> target, int columnIndex, ExistingData existingData = ExistingData.Clear)
		{
		}

		public void CopySubColumnTo(VectorStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopySubColumnToUnchecked(VectorStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount, ExistingData existingData)
		{
		}

		public void TransposeTo(MatrixStorage<T> target, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void TransposeToUnchecked(MatrixStorage<T> target, ExistingData existingData)
		{
		}

		internal virtual void TransposeSquareInplaceUnchecked()
		{
		}

		public virtual T[] ToRowMajorArray()
		{
			return null;
		}

		public virtual T[] ToColumnMajorArray()
		{
			return null;
		}

		public virtual T[][] ToRowArrays()
		{
			return null;
		}

		public virtual T[][] ToColumnArrays()
		{
			return null;
		}

		public virtual T[,] ToArray()
		{
			return null;
		}

		public virtual T[] AsRowMajorArray()
		{
			return null;
		}

		public virtual T[] AsColumnMajorArray()
		{
			return null;
		}

		public virtual T[][] AsRowArrays()
		{
			return null;
		}

		public virtual T[][] AsColumnArrays()
		{
			return null;
		}

		public virtual T[,] AsArray()
		{
			return null;
		}

		[IteratorStateMachine(typeof(MatrixStorage<>._003CEnumerate_003Ed__47))]
		public virtual IEnumerable<T> Enumerate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(MatrixStorage<>._003CEnumerateIndexed_003Ed__48))]
		public virtual IEnumerable<(int, int, T)> EnumerateIndexed()
		{
			return null;
		}

		[IteratorStateMachine(typeof(MatrixStorage<>._003CEnumerateNonZero_003Ed__49))]
		public virtual IEnumerable<T> EnumerateNonZero()
		{
			return null;
		}

		[IteratorStateMachine(typeof(MatrixStorage<>._003CEnumerateNonZeroIndexed_003Ed__50))]
		public virtual IEnumerable<(int, int, T)> EnumerateNonZeroIndexed()
		{
			return null;
		}

		public virtual Tuple<int, int, T> Find(Func<T, bool> predicate, Zeros zeros)
		{
			return null;
		}

		public Tuple<int, int, T, TOther> Find2<TOther>(MatrixStorage<TOther> other, Func<T, TOther, bool> predicate, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return null;
		}

		internal virtual Tuple<int, int, T, TOther> Find2Unchecked<TOther>(MatrixStorage<TOther> other, Func<T, TOther, bool> predicate, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return null;
		}

		public virtual void MapInplace(Func<T, T> f, Zeros zeros)
		{
		}

		public virtual void MapIndexedInplace(Func<int, int, T, T> f, Zeros zeros)
		{
		}

		public void MapTo<TU>(MatrixStorage<TU> target, Func<T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		internal virtual void MapToUnchecked<TU>(MatrixStorage<TU> target, Func<T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void MapIndexedTo<TU>(MatrixStorage<TU> target, Func<int, int, T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		internal virtual void MapIndexedToUnchecked<TU>(MatrixStorage<TU> target, Func<int, int, T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void MapSubMatrixIndexedTo<TU>(MatrixStorage<TU> target, Func<int, int, T, TU> f, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		internal virtual void MapSubMatrixIndexedToUnchecked<TU>(MatrixStorage<TU> target, Func<int, int, T, TU> f, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void Map2To(MatrixStorage<T> target, MatrixStorage<T> other, Func<T, T, T> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal virtual void Map2ToUnchecked(MatrixStorage<T> target, MatrixStorage<T> other, Func<T, T, T> f, Zeros zeros, ExistingData existingData)
		{
		}

		public void FoldByRow<TU>(TU[] target, Func<TU, T, TU> f, Func<TU, int, TU> finalize, TU[] state, Zeros zeros)
		{
		}

		internal virtual void FoldByRowUnchecked<TU>(TU[] target, Func<TU, T, TU> f, Func<TU, int, TU> finalize, TU[] state, Zeros zeros)
		{
		}

		public void FoldByColumn<TU>(TU[] target, Func<TU, T, TU> f, Func<TU, int, TU> finalize, TU[] state, Zeros zeros)
		{
		}

		internal virtual void FoldByColumnUnchecked<TU>(TU[] target, Func<TU, T, TU> f, Func<TU, int, TU> finalize, TU[] state, Zeros zeros)
		{
		}

		public TState Fold2<TOther, TState>(MatrixStorage<TOther> other, Func<TState, T, TOther, TState> f, TState state, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return default(TState);
		}

		internal virtual TState Fold2Unchecked<TOther, TState>(MatrixStorage<TOther> other, Func<TState, T, TOther, TState> f, TState state, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return default(TState);
		}

		private void ValidateRange(int row, int column)
		{
		}

		private void ValidateSubMatrixRange<TU>(MatrixStorage<TU> target, int sourceRowIndex, int targetRowIndex, int rowCount, int sourceColumnIndex, int targetColumnIndex, int columnCount) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		private void ValidateRowRange<TU>(VectorStorage<TU> target, int rowIndex) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		private void ValidateColumnRange<TU>(VectorStorage<TU> target, int columnIndex) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		private void ValidateSubRowRange<TU>(VectorStorage<TU> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		private void ValidateSubColumnRange<TU>(VectorStorage<TU> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount) where TU : struct, IEquatable<TU>, IFormattable
		{
		}
	}
}
