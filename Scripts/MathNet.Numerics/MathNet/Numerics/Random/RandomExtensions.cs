using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Random
{
	public static class RandomExtensions
	{
		[CompilerGenerated]
		private sealed class _003CNextBigIntegerSequence_003Ed__9 : IEnumerable<BigInteger>, IEnumerable, IEnumerator<BigInteger>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private BigInteger _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private BigInteger maxExclusive;

			public BigInteger _003C_003E3__maxExclusive;

			private BigInteger minInclusive;

			public BigInteger _003C_003E3__minInclusive;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private BigInteger _003CabsoluteRange_003E5__2;

			private int _003CnumBytes_003E5__3;

			private byte[] _003CbyteSequence_003E5__4;

			private BigInteger _003CvalidRange_003E5__5;

			private BigInteger System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ENumerics_002EBigInteger_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(BigInteger);
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
			public _003CNextBigIntegerSequence_003Ed__9(int _003C_003E1__state)
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
			private IEnumerator<BigInteger> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ENumerics_002EBigInteger_003E_002EGetEnumerator()
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
		private sealed class _003CNextDoubleSequenceEnumerable_003Ed__3 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

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
			public _003CNextDoubleSequenceEnumerable_003Ed__3(int _003C_003E1__state)
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
		private sealed class _003CNextInt32SequenceEnumerable_003Ed__8 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private int minInclusive;

			public int _003C_003E3__minInclusive;

			private int maxExclusive;

			public int _003C_003E3__maxExclusive;

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
			public _003CNextInt32SequenceEnumerable_003Ed__8(int _003C_003E1__state)
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

		public static void NextDoubles(this System.Random rnd, double[] values)
		{
		}

		public static double[] NextDoubles(this System.Random rnd, int count)
		{
			return null;
		}

		public static IEnumerable<double> NextDoubleSequence(this System.Random rnd)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CNextDoubleSequenceEnumerable_003Ed__3))]
		private static IEnumerable<double> NextDoubleSequenceEnumerable(System.Random rnd)
		{
			return null;
		}

		public static byte[] NextBytes(this System.Random rnd, int count)
		{
			return null;
		}

		public static void NextInt32s(this System.Random rnd, int[] values)
		{
		}

		public static void NextInt32s(this System.Random rnd, int[] values, int minInclusive, int maxExclusive)
		{
		}

		public static IEnumerable<int> NextInt32Sequence(this System.Random rnd, int minInclusive, int maxExclusive)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CNextInt32SequenceEnumerable_003Ed__8))]
		private static IEnumerable<int> NextInt32SequenceEnumerable(System.Random rnd, int minInclusive, int maxExclusive)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CNextBigIntegerSequence_003Ed__9))]
		public static IEnumerable<BigInteger> NextBigIntegerSequence(this System.Random rnd, BigInteger minInclusive, BigInteger maxExclusive)
		{
			return null;
		}

		public static long NextInt64(this System.Random rnd)
		{
			return 0L;
		}

		public static int NextFullRangeInt32(this System.Random rnd)
		{
			return 0;
		}

		public static long NextFullRangeInt64(this System.Random rnd)
		{
			return 0L;
		}

		public static decimal NextDecimal(this System.Random rnd)
		{
			return default(decimal);
		}

		public static bool NextBoolean(this System.Random rnd)
		{
			return false;
		}
	}
}
