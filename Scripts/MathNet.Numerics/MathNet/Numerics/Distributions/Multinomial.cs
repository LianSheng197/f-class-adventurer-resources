using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Statistics;

namespace MathNet.Numerics.Distributions
{
	public class Multinomial : IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamples_003Ed__24 : IEnumerable<int[]>, IEnumerable, IEnumerator<int[]>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int[] _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Multinomial _003C_003E4__this;

			private int[] System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_005B_005D_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CSamples_003Ed__24(int _003C_003E1__state)
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
			private IEnumerator<int[]> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_005B_005D_003E_002EGetEnumerator()
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
		private sealed class _003CSamples_003Ed__26 : IEnumerable<int[]>, IEnumerable, IEnumerator<int[]>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int[] _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private double[] p;

			public double[] _003C_003E3__p;

			private int n;

			public int _003C_003E3__n;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double[] _003Ccp_003E5__2;

			private int[] System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_005B_005D_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CSamples_003Ed__26(int _003C_003E1__state)
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
			private IEnumerator<int[]> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_005B_005D_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private System.Random _random;

		private readonly double[] _p;

		private readonly int _trials;

		public double[] P => null;

		public int N => 0;

		public System.Random RandomSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector<double> Mean => null;

		public Vector<double> Variance => null;

		public Vector<double> Skewness => null;

		public Multinomial(double[] p, int n)
		{
		}

		public Multinomial(double[] p, int n, System.Random randomSource)
		{
		}

		public Multinomial(Histogram h, int n)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(IEnumerable<double> p, int n)
		{
			return false;
		}

		public double Probability(int[] x)
		{
			return 0.0;
		}

		public double ProbabilityLn(int[] x)
		{
			return 0.0;
		}

		public int[] Sample()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSamples_003Ed__24))]
		public IEnumerable<int[]> Samples()
		{
			return null;
		}

		public static int[] Sample(System.Random rnd, double[] p, int n)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSamples_003Ed__26))]
		public static IEnumerable<int[]> Samples(System.Random rnd, double[] p, int n)
		{
			return null;
		}
	}
}
