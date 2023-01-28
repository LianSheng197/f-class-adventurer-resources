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
	[DataContract(Namespace = "urn:MathNet/Numerics/LinearAlgebra")]
	[DefaultMember("Item")]
	public abstract class VectorStorage<T> : IEquatable<VectorStorage<T>> where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__29 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VectorStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CEnumerate_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CEnumerateIndexed_003Ed__30 : IEnumerable<(int, T)>, IEnumerable, IEnumerator<(int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VectorStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private (int, T) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CT_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, T));
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
			public _003CEnumerateIndexed_003Ed__30(int _003C_003E1__state)
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
			private IEnumerator<(int, T)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CT_0029_003E_002EGetEnumerator()
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
		private sealed class _003CEnumerateNonZero_003Ed__31 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VectorStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CEnumerateNonZero_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CEnumerateNonZeroIndexed_003Ed__32 : IEnumerable<(int, T)>, IEnumerable, IEnumerator<(int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VectorStorage<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private (int, T) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EInt32_002CT_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((int, T));
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
			public _003CEnumerateNonZeroIndexed_003Ed__32(int _003C_003E1__state)
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
			private IEnumerator<(int, T)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EInt32_002CT_0029_003E_002EGetEnumerator()
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
		public readonly int Length;

		public abstract bool IsDense { get; }

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

		protected VectorStorage(int length)
		{
		}

		public abstract T At(int index);

		public abstract void At(int index, T value);

		public virtual bool Equals(VectorStorage<T> other)
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

		public virtual void Clear(int index, int count)
		{
		}

		public void CopyTo(VectorStorage<T> target, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopyToUnchecked(VectorStorage<T> target, ExistingData existingData)
		{
		}

		public void CopyToRow(MatrixStorage<T> target, int rowIndex, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopyToRowUnchecked(MatrixStorage<T> target, int rowIndex, ExistingData existingData)
		{
		}

		public void CopyToColumn(MatrixStorage<T> target, int columnIndex, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopyToColumnUnchecked(MatrixStorage<T> target, int columnIndex, ExistingData existingData)
		{
		}

		public void CopySubVectorTo(VectorStorage<T> target, int sourceIndex, int targetIndex, int count, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopySubVectorToUnchecked(VectorStorage<T> target, int sourceIndex, int targetIndex, int count, ExistingData existingData)
		{
		}

		public void CopyToSubRow(MatrixStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopyToSubRowUnchecked(MatrixStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		public void CopyToSubColumn(MatrixStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount, ExistingData existingData = ExistingData.Clear)
		{
		}

		internal virtual void CopyToSubColumnUnchecked(MatrixStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount, ExistingData existingData)
		{
		}

		public virtual T[] ToArray()
		{
			return null;
		}

		public virtual T[] AsArray()
		{
			return null;
		}

		[IteratorStateMachine(typeof(VectorStorage<>._003CEnumerate_003Ed__29))]
		public virtual IEnumerable<T> Enumerate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(VectorStorage<>._003CEnumerateIndexed_003Ed__30))]
		public virtual IEnumerable<(int, T)> EnumerateIndexed()
		{
			return null;
		}

		[IteratorStateMachine(typeof(VectorStorage<>._003CEnumerateNonZero_003Ed__31))]
		public virtual IEnumerable<T> EnumerateNonZero()
		{
			return null;
		}

		[IteratorStateMachine(typeof(VectorStorage<>._003CEnumerateNonZeroIndexed_003Ed__32))]
		public virtual IEnumerable<(int, T)> EnumerateNonZeroIndexed()
		{
			return null;
		}

		public virtual Tuple<int, T> Find(Func<T, bool> predicate, Zeros zeros)
		{
			return null;
		}

		public Tuple<int, T, TOther> Find2<TOther>(VectorStorage<TOther> other, Func<T, TOther, bool> predicate, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return null;
		}

		internal virtual Tuple<int, T, TOther> Find2Unchecked<TOther>(VectorStorage<TOther> other, Func<T, TOther, bool> predicate, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return null;
		}

		public virtual void MapInplace(Func<T, T> f, Zeros zeros)
		{
		}

		public virtual void MapIndexedInplace(Func<int, T, T> f, Zeros zeros)
		{
		}

		public void MapTo<TU>(VectorStorage<TU> target, Func<T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		internal virtual void MapToUnchecked<TU>(VectorStorage<TU> target, Func<T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void MapIndexedTo<TU>(VectorStorage<TU> target, Func<int, T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		internal virtual void MapIndexedToUnchecked<TU>(VectorStorage<TU> target, Func<int, T, TU> f, Zeros zeros, ExistingData existingData) where TU : struct, IEquatable<TU>, IFormattable
		{
		}

		public void Map2To(VectorStorage<T> target, VectorStorage<T> other, Func<T, T, T> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal virtual void Map2ToUnchecked(VectorStorage<T> target, VectorStorage<T> other, Func<T, T, T> f, Zeros zeros, ExistingData existingData)
		{
		}

		public TState Fold2<TOther, TState>(VectorStorage<TOther> other, Func<TState, T, TOther, TState> f, TState state, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return default(TState);
		}

		internal virtual TState Fold2Unchecked<TOther, TState>(VectorStorage<TOther> other, Func<TState, T, TOther, TState> f, TState state, Zeros zeros) where TOther : struct, IEquatable<TOther>, IFormattable
		{
			return default(TState);
		}

		private void ValidateRange(int index)
		{
		}

		private void ValidateSubVectorRange(VectorStorage<T> target, int sourceIndex, int targetIndex, int count)
		{
		}

		private void ValidateRowRange(MatrixStorage<T> target, int rowIndex)
		{
		}

		private void ValidateColumnRange(MatrixStorage<T> target, int columnIndex)
		{
		}

		private void ValidateSubRowRange(MatrixStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount)
		{
		}

		private void ValidateSubColumnRange(MatrixStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount)
		{
		}
	}
}
