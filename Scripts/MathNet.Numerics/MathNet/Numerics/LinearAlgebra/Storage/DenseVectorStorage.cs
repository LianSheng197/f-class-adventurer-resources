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
	public class DenseVectorStorage<T> : VectorStorage<T> where T : struct, IEquatable<T>, IFormattable
	{
		[CompilerGenerated]
		private sealed class _003CEnumerateNonZeroIndexed_003Ed__26 : IEnumerable<(int, T)>, IEnumerable, IEnumerator<(int, T)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (int, T) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public DenseVectorStorage<T> _003C_003E4__this;

			private T[] _003Cdata_003E5__2;

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
			public _003CEnumerateNonZeroIndexed_003Ed__26(int _003C_003E1__state)
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
		public readonly T[] Data;

		public override bool IsDense => false;

		internal DenseVectorStorage(int length)
		{
			((VectorStorage<>)(object)this)._002Ector(0);
		}

		internal DenseVectorStorage(int length, T[] data)
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

		public override void Clear()
		{
		}

		public override void Clear(int index, int count)
		{
		}

		public static DenseVectorStorage<T> OfVector(VectorStorage<T> vector)
		{
			return null;
		}

		public static DenseVectorStorage<T> OfValue(int length, T value)
		{
			return null;
		}

		public static DenseVectorStorage<T> OfInit(int length, Func<int, T> init)
		{
			return null;
		}

		public static DenseVectorStorage<T> OfEnumerable(IEnumerable<T> data)
		{
			return null;
		}

		public static DenseVectorStorage<T> OfIndexedEnumerable(int length, IEnumerable<Tuple<int, T>> data)
		{
			return null;
		}

		public static DenseVectorStorage<T> OfIndexedEnumerable(int length, IEnumerable<(int, T)> data)
		{
			return null;
		}

		internal override void CopyToUnchecked(VectorStorage<T> target, ExistingData existingData)
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

		internal override void CopyToSubRowUnchecked(MatrixStorage<T> target, int rowIndex, int sourceColumnIndex, int targetColumnIndex, int columnCount, ExistingData existingData)
		{
		}

		internal override void CopyToSubColumnUnchecked(MatrixStorage<T> target, int columnIndex, int sourceRowIndex, int targetRowIndex, int rowCount, ExistingData existingData)
		{
		}

		public override T[] ToArray()
		{
			return null;
		}

		public override T[] AsArray()
		{
			return null;
		}

		public override IEnumerable<T> Enumerate()
		{
			return null;
		}

		public override IEnumerable<(int, T)> EnumerateIndexed()
		{
			return null;
		}

		public override IEnumerable<T> EnumerateNonZero()
		{
			return null;
		}

		[IteratorStateMachine(typeof(DenseVectorStorage<>._003CEnumerateNonZeroIndexed_003Ed__26))]
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
