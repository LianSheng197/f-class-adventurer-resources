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
	public class WH2006 : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__19 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private ulong _003Cwn_003E5__2;

			private ulong _003Cxn_003E5__3;

			private ulong _003Cyn_003E5__4;

			private ulong _003Czn_003E5__5;

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
			public _003CDoubleSequence_003Ed__19(int _003C_003E1__state)
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

		private const uint Modw = 2147483123u;

		private const double ModwRecip = 4.656614011489952E-10;

		private const uint Modx = 2147483579u;

		private const double ModxRecip = 4.656613022697298E-10;

		private const uint Mody = 2147483543u;

		private const double ModyRecip = 4.65661310075986E-10;

		private const uint Modz = 2147483423u;

		private const double ModzRecip = 4.656613360968421E-10;

		[DataMember(Order = 1)]
		private ulong _wn;

		[DataMember(Order = 2)]
		private ulong _xn;

		[DataMember(Order = 3)]
		private ulong _yn;

		[DataMember(Order = 4)]
		private ulong _zn;

		public WH2006()
		{
		}

		public WH2006(bool threadSafe)
		{
		}

		public WH2006(int seed)
		{
		}

		public WH2006(int seed, bool threadSafe)
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

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__19))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}
	}
}
