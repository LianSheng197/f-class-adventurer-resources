using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace MathNet.Numerics.Random
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics/Random")]
	public class MersenneTwister : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__23 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private uint[] _003Ct_003E5__2;

			private int _003Ck_003E5__3;

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
			public _003CDoubleSequence_003Ed__23(int _003C_003E1__state)
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

		private const uint LowerMask = 2147483647u;

		private const int M = 397;

		private const uint MatrixA = 2567483615u;

		private const int N = 624;

		private const double Reciprocal = 2.3283064365386963E-10;

		private const uint UpperMask = 2147483648u;

		private static readonly uint[] Mag01;

		[DataMember(Order = 1)]
		private readonly uint[] _mt;

		[DataMember(Order = 2)]
		private int _mti;

		private static readonly ThreadLocal<MersenneTwister> DefaultInstance;

		public static MersenneTwister Default => null;

		public MersenneTwister()
		{
		}

		public MersenneTwister(bool threadSafe)
		{
		}

		public MersenneTwister(int seed)
		{
		}

		public MersenneTwister(int seed, bool threadSafe)
		{
		}

		private void init_genrand(uint s)
		{
		}

		private uint genrand_int32()
		{
			return 0u;
		}

		protected sealed override double DoSample()
		{
			return 0.0;
		}

		protected sealed override int DoSampleInteger()
		{
			return 0;
		}

		protected sealed override void DoSampleBytes(byte[] buffer)
		{
		}

		public static void Doubles(double[] values, int seed)
		{
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double[] Doubles(int length, int seed)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__23))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}
	}
}
