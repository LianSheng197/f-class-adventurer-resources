using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Random
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics/Random")]
	public class Xoshiro256StarStar : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__18 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private ulong _003Cs0_003E5__2;

			private ulong _003Cs1_003E5__3;

			private ulong _003Cs2_003E5__4;

			private ulong _003Cs3_003E5__5;

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
			public _003CDoubleSequence_003Ed__18(int _003C_003E1__state)
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

		private const double REAL_UNIT_UINT = 1.1102230246251565E-16;

		[DataMember(Order = 1)]
		private ulong _s0;

		[DataMember(Order = 2)]
		private ulong _s1;

		[DataMember(Order = 3)]
		private ulong _s2;

		[DataMember(Order = 4)]
		private ulong _s3;

		public Xoshiro256StarStar()
		{
		}

		public Xoshiro256StarStar(bool threadSafe)
		{
		}

		public Xoshiro256StarStar(int seed)
		{
		}

		public Xoshiro256StarStar(int seed, bool threadSafe)
		{
		}

		protected sealed override double DoSample()
		{
			return 0.0;
		}

		protected override int DoSampleInteger()
		{
			return 0;
		}

		protected override void DoSampleBytes(byte[] buffer)
		{
		}

		protected override int DoSampleInt32WithNBits(int bitCount)
		{
			return 0;
		}

		protected override long DoSampleInt64WithNBits(int bitCount)
		{
			return 0L;
		}

		private void Initialise(int seed)
		{
		}

		private ulong NextInnerULong()
		{
			return 0uL;
		}

		public static void Doubles(double[] values, int seed)
		{
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double[] Doubles(int length, int seed)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__18))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}

		private static ulong Splitmix64(ref ulong x)
		{
			return 0uL;
		}

		private static ulong RotateLeft(ulong x, int k)
		{
			return 0uL;
		}
	}
}
