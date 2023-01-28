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
	public class SparseVectorStorage<T> : VectorStorage<T> where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__28 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public SparseVectorStorage<T> _003C_003E4__this;

			private int _003Ck_003E5__2;

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
			public _003CEnumerate_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CEnumerateIndexed_003Ed__29 : IEnumerable<(int, T)>, IEnumerable, IEnumerator<(int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public SparseVectorStorage<T> _003C_003E4__this;

			private int _003Ck_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CEnumerateIndexed_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CEnumerateNonZeroIndexed_003Ed__31 : IEnumerable<(int, T)>, IEnumerable, IEnumerator<(int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public SparseVectorStorage<T> _003C_003E4__this;

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
			public _003CEnumerateNonZeroIndexed_003Ed__31(int _003C_003E1__state)
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

		[DataMember(Order = 1)]
		public int[] Indices;

		[DataMember(Order = 2)]
		public T[] Values;

		[DataMember(Order = 3)]
		public int ValueCount;

		public override bool IsDense => false;

		internal SparseVectorStorage(int length)
		{
			((VectorStorage<>)(object)this)._002Ector(0);
		}

		public override T At(int index)
		{
			return default(T);
		}

		public override void At(int index, T value)
		{
		}

		internal void InsertAtIndexUnchecked(int itemIndex, int index, T value)
		{
		}

		internal void RemoveAtIndexUnchecked(int itemIndex)
		{
		}

		private int GrowthSize()
		{
			return 0;
		}

		public override bool Equals(VectorStorage<T> other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public override void Clear(int index, int count)
		{
		}

		public static SparseVectorStorage<T> OfVector(VectorStorage<T> vector)
		{
			return null;
		}

		public static SparseVectorStorage<T> OfValue(int length, T value)
		{
			return null;
		}

		public static SparseVectorStorage<T> OfInit(int length, Func<int, T> init)
		{
			return null;
		}

		public static SparseVectorStorage<T> OfEnumerable(IEnumerable<T> data)
		{
			return null;
		}

		public static SparseVectorStorage<T> OfIndexedEnumerable(int length, IEnumerable<Tuple<int, T>> data)
		{
			return null;
		}

		public static SparseVectorStorage<T> OfIndexedEnumerable(int length, IEnumerable<(int, T)> data)
		{
			return null;
		}

		internal override void CopyToUnchecked(VectorStorage<T> target, ExistingData existingData)
		{
		}

		private void CopyToUnchecked(SparseVectorStorage<T> target)
		{
		}

		internal override void CopyToRowUnchecked(MatrixStorage<T> target, int rowIndex, ExistingData existingData)
		{
		}

		internal override void CopyToColumnUnchecked(MatrixStorage<T> target, int columnIndex, ExistingData existingData)
		{
		}

		internal override void CopySubVectorToUnchecked(VectorStorage<T> target, int sourceIndex, int targetIndex, int count, ExistingData existingData)
		{
		}

		private void CopySubVectorToUnchecked(SparseVectorStorage<T> target, int sourceIndex, int targetIndex, int count, ExistingData existingData)
		{
		}

		public override T[] ToArray()
		{
			return null;
		}

		[IteratorStateMachine(typeof(SparseVectorStorage<>._003CEnumerate_003Ed__28))]
		public override IEnumerable<T> Enumerate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(SparseVectorStorage<>._003CEnumerateIndexed_003Ed__29))]
		public override IEnumerable<(int, T)> EnumerateIndexed()
		{
			return null;
		}

		public override IEnumerable<T> EnumerateNonZero()
		{
			return null;
		}

		[IteratorStateMachine(typeof(SparseVectorStorage<>._003CEnumerateNonZeroIndexed_003Ed__31))]
		public override IEnumerable<(int, T)> EnumerateNonZeroIndexed()
		{
			return null;
		}

		public override Tuple<int, T> Find(Func<T, bool> predicate, Zeros zeros)
		{
			return null;
		}

		internal override Tuple<int, T, TOther> Find2Unchecked<TOther>(VectorStorage<TOther> other, Func<T, TOther, bool> predicate, Zeros zeros)
		{
			return null;
		}

		public override void MapInplace(Func<T, T> f, Zeros zeros)
		{
		}

		public override void MapIndexedInplace(Func<int, T, T> f, Zeros zeros)
		{
		}

		internal override void MapToUnchecked<TU>(VectorStorage<TU> target, Func<T, TU> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal override void MapIndexedToUnchecked<TU>(VectorStorage<TU> target, Func<int, T, TU> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal override void Map2ToUnchecked(VectorStorage<T> target, VectorStorage<T> other, Func<T, T, T> f, Zeros zeros, ExistingData existingData)
		{
		}

		internal override TState Fold2Unchecked<TOther, TState>(VectorStorage<TOther> other, Func<TState, T, TOther, TState> f, TState state, Zeros zeros)
		{
			return default(TState);
		}
	}
}
