using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Random
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics/Random")]
	public abstract class RandomSource : System.Random
	{
		[CompilerGenerated]
		private sealed class _003CNextDoubleSequence_003Ed__6 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public RandomSource _003C_003E4__this;

			private double[] _003Cbuffer_003E5__2;

			private int _003Ci_003E5__3;

			private double System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EDouble_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0.0;
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
			public _003CNextDoubleSequence_003Ed__6(int _003C_003E1__state)
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
			private IEnumerator<double> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EDouble_003E_002EGetEnumerator()
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
		private sealed class _003CNextInt32Sequence_003Ed__16 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public RandomSource _003C_003E4__this;

			private int[] _003Cbuffer_003E5__2;

			private int _003Ci_003E5__3;

			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CNextInt32Sequence_003Ed__16(int _003C_003E1__state)
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
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
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
		private sealed class _003CNextInt32Sequence_003Ed__17 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int minInclusive;

			public int _003C_003E3__minInclusive;

			private int maxExclusive;

			public int _003C_003E3__maxExclusive;

			public RandomSource _003C_003E4__this;

			private int[] _003Cbuffer_003E5__2;

			private int _003Ci_003E5__3;

			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CNextInt32Sequence_003Ed__17(int _003C_003E1__state)
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
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private readonly bool _threadSafe;

		private readonly object _lock;

		protected RandomSource()
		{
		}

		protected RandomSource(bool threadSafe)
		{
		}

		public void NextDoubles(double[] values)
		{
		}

		public double[] NextDoubles(int count)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CNextDoubleSequence_003Ed__6))]
		public IEnumerable<double> NextDoubleSequence()
		{
			return null;
		}

		public sealed override int Next()
		{
			return 0;
		}

		public sealed override int Next(int maxExclusive)
		{
			return 0;
		}

		public sealed override int Next(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		public void NextInt32s(int[] values)
		{
		}

		public int[] NextInt32s(int count)
		{
			return null;
		}

		public void NextInt32s(int[] values, int maxExclusive)
		{
		}

		public int[] NextInt32s(int count, int maxExclusive)
		{
			return null;
		}

		public void NextInt32s(int[] values, int minInclusive, int maxExclusive)
		{
		}

		public int[] NextInt32s(int count, int minInclusive, int maxExclusive)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CNextInt32Sequence_003Ed__16))]
		public IEnumerable<int> NextInt32Sequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CNextInt32Sequence_003Ed__17))]
		public IEnumerable<int> NextInt32Sequence(int minInclusive, int maxExclusive)
		{
			return null;
		}

		public sealed override void NextBytes(byte[] buffer)
		{
		}

		protected sealed override double Sample()
		{
			return 0.0;
		}

		protected abstract double DoSample();

		protected virtual int DoSampleInteger()
		{
			return 0;
		}

		protected virtual void DoSampleBytes(byte[] buffer)
		{
		}

		protected virtual int DoSampleInt32WithNBits(int bitCount)
		{
			return 0;
		}

		protected virtual long DoSampleInt64WithNBits(int bitCount)
		{
			return 0L;
		}

		protected virtual int DoSampleInteger(int maxExclusive)
		{
			return 0;
		}

		protected virtual int DoSampleInteger(int minInclusive, int maxExclusive)
		{
			return 0;
		}
	}
}
