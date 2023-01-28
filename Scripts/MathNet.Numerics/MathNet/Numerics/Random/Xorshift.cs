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
	public class Xorshift : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__23 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private ulong a;

			public ulong _003C_003E3__a;

			private ulong c;

			public ulong _003C_003E3__c;

			private int seed;

			public int _003C_003E3__seed;

			private ulong x1;

			public ulong _003C_003E3__x1;

			private ulong x2;

			public ulong _003C_003E3__x2;

			private ulong _003Cx_003E5__2;

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

		private const uint YSeed = 362436069u;

		private const uint ZSeed = 77465321u;

		private const uint ASeed = 916905990u;

		private const uint CSeed = 13579u;

		private const double UlongToDoubleMultiplier = 2.3283064365386963E-10;

		[DataMember(Order = 1)]
		private ulong _x;

		[DataMember(Order = 2)]
		private ulong _y;

		[DataMember(Order = 3)]
		private ulong _z;

		[DataMember(Order = 4)]
		private ulong _c;

		[DataMember(Order = 5)]
		private readonly ulong _a;

		public Xorshift()
		{
		}

		public Xorshift(long a, long c, long x1, long x2)
		{
		}

		public Xorshift(bool threadSafe)
		{
		}

		public Xorshift(bool threadSafe, long a, long c, long x1, long x2)
		{
		}

		public Xorshift(int seed)
		{
		}

		public Xorshift(int seed, long a, long c, long x1, long x2)
		{
		}

		public Xorshift(int seed, bool threadSafe)
		{
		}

		public Xorshift(int seed, bool threadSafe, long a, long c, long x1, long x2)
		{
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

		[CLSCompliant(false)]
		public static void Doubles(double[] values, int seed, ulong a = 916905990uL, ulong c = 13579uL, ulong x1 = 362436069uL, ulong x2 = 77465321uL)
		{
		}

		[CLSCompliant(false)]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double[] Doubles(int length, int seed, ulong a = 916905990uL, ulong c = 13579uL, ulong x1 = 362436069uL, ulong x2 = 77465321uL)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__23))]
		[CLSCompliant(false)]
		public static IEnumerable<double> DoubleSequence(int seed, ulong a = 916905990uL, ulong c = 13579uL, ulong x1 = 362436069uL, ulong x2 = 77465321uL)
		{
			return null;
		}
	}
}
