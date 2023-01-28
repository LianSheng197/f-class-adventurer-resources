using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.RootFinding
{
	public static class ZeroCrossingBracketing
	{
		[CompilerGenerated]
		private sealed class _003CFindIntervalsWithin_003Ed__0 : IEnumerable<(double, double)>, IEnumerable, IEnumerator<(double, double)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (double, double) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Func<double, double> f;

			public Func<double, double> _003C_003E3__f;

			private double lowerBound;

			public double _003C_003E3__lowerBound;

			private double upperBound;

			public double _003C_003E3__upperBound;

			private int subdivisions;

			public int _003C_003E3__subdivisions;

			private double _003Csubdiv_003E5__2;

			private int _003Ck_003E5__3;

			private double _003Csmax_003E5__4;

			private double _003Csfmax_003E5__5;

			private (double, double) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028System_002EDouble_002CSystem_002EDouble_0029_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default((double, double));
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
			public _003CFindIntervalsWithin_003Ed__0(int _003C_003E1__state)
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
			private IEnumerator<(double, double)> System_002ECollections_002EGeneric_002EIEnumerable_003C_0028System_002EDouble_002CSystem_002EDouble_0029_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[IteratorStateMachine(typeof(_003CFindIntervalsWithin_003Ed__0))]
		public static IEnumerable<(double, double)> FindIntervalsWithin(Func<double, double> f, double lowerBound, double upperBound, int subdivisions)
		{
			return null;
		}

		public static bool Expand(Func<double, double> f, ref double lowerBound, ref double upperBound, double factor = 1.6, int maxIterations = 50)
		{
			return false;
		}

		public static bool Reduce(Func<double, double> f, ref double lowerBound, ref double upperBound, int subdivisions = 1000)
		{
			return false;
		}

		public static bool ExpandReduce(Func<double, double> f, ref double lowerBound, ref double upperBound, double expansionFactor = 1.6, int expansionMaxIterations = 50, int reduceSubdivisions = 100)
		{
			return false;
		}
	}
}
