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
	public class Mcg59 : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__11 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private ulong _003Cxn_003E5__2;

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
			public _003CDoubleSequence_003Ed__11(int _003C_003E1__state)
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

		private const ulong Modulus = 576460752303423488uL;

		private const ulong Multiplier = 302875106592253uL;

		private const double Reciprocal = 1.734723475976807E-18;

		[DataMember(Order = 1)]
		private ulong _xn;

		public Mcg59()
		{
		}

		public Mcg59(bool threadSafe)
		{
		}

		public Mcg59(int seed)
		{
		}

		public Mcg59(int seed, bool threadSafe)
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

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__11))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}
	}
}
