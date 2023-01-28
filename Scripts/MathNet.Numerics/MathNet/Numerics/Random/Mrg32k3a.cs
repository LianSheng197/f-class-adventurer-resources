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
	public class Mrg32k3a : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__20 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private double _003Cx1_003E5__2;

			private double _003Cx2_003E5__3;

			private double _003Cx3_003E5__4;

			private double _003Cy1_003E5__5;

			private double _003Cy2_003E5__6;

			private double _003Cy3_003E5__7;

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
			public _003CDoubleSequence_003Ed__20(int _003C_003E1__state)
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

		private const double A12 = 1403580.0;

		private const double A13 = 810728.0;

		private const double A21 = 527612.0;

		private const double A23 = 1370589.0;

		private const double Modulus1 = 4294967087.0;

		private const double Modulus2 = 4294944443.0;

		private const double Reciprocal = 2.328306549837829E-10;

		[DataMember(Order = 1)]
		private double _xn1;

		[DataMember(Order = 2)]
		private double _xn2;

		[DataMember(Order = 3)]
		private double _xn3;

		[DataMember(Order = 4)]
		private double _yn1;

		[DataMember(Order = 5)]
		private double _yn2;

		[DataMember(Order = 6)]
		private double _yn3;

		public Mrg32k3a()
		{
		}

		public Mrg32k3a(bool threadSafe)
		{
		}

		public Mrg32k3a(int seed)
		{
		}

		public Mrg32k3a(int seed, bool threadSafe)
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

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__20))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}
	}
}
