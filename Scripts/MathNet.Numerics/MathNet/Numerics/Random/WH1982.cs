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
	public class WH1982 : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__16 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private uint _003Cxn_003E5__2;

			private uint _003Cyn_003E5__3;

			private uint _003Czn_003E5__4;

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
			public _003CDoubleSequence_003Ed__16(int _003C_003E1__state)
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

		private const uint Modx = 30269u;

		private const double ModxRecip = 3.3037100664045725E-05;

		private const uint Mody = 30307u;

		private const double ModyRecip = 3.2995677566238825E-05;

		private const uint Modz = 30323u;

		private const double ModzRecip = 3.297826732183491E-05;

		[DataMember(Order = 1)]
		private uint _xn;

		[DataMember(Order = 2)]
		private uint _yn;

		[DataMember(Order = 3)]
		private uint _zn;

		public WH1982()
		{
		}

		public WH1982(bool threadSafe)
		{
		}

		public WH1982(int seed)
		{
		}

		public WH1982(int seed, bool threadSafe)
		{
		}

		protected sealed override double DoSample()
		{
			return 0.0;
		}

		public static void Doubles(double[] values, int seed)
		{
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double[] Doubles(int length, int seed)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__16))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}
	}
}
