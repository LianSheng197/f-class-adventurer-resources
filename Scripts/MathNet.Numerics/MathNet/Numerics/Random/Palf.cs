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
	public class Palf : RandomSource
	{
		[CompilerGenerated]
		private sealed class _003CDoubleSequence_003Ed__24 : IEnumerable<double>, IEnumerable, IEnumerator<double>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private double _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int seed;

			public int _003C_003E3__seed;

			private int _003Cthreads_003E5__2;

			private int _003ClongLag_003E5__3;

			private uint[] _003Cx_003E5__4;

			private int _003Ck_003E5__5;

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
			public _003CDoubleSequence_003Ed__24(int _003C_003E1__state)
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

		private const int DefaultShortLag = 418;

		private const int DefaultLongLag = 1279;

		private const double Reciprocal = 2.3283064365386963E-10;

		[DataMember(Order = 3)]
		private readonly uint[] _x;

		[DataMember(Order = 4)]
		private readonly int _threads;

		[DataMember(Order = 5)]
		private int _k;

		[DataMember(Order = 1)]
		public int ShortLag
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 2)]
		public int LongLag
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Palf()
		{
		}

		public Palf(bool threadSafe)
		{
		}

		public Palf(int seed)
		{
		}

		public Palf(int seed, bool threadSafe)
		{
		}

		public Palf(int seed, bool threadSafe, int shortLag, int longLag)
		{
		}

		private void Fill()
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

		public static void Doubles(double[] values, int seed)
		{
		}

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public static double[] Doubles(int length, int seed)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoubleSequence_003Ed__24))]
		public static IEnumerable<double> DoubleSequence(int seed)
		{
			return null;
		}
	}
}
