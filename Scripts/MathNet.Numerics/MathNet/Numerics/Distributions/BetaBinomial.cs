using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Distributions
{
	public class BetaBinomial : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__44 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private int n;

			public int _003C_003E3__n;

			private double a;

			public double _003C_003E3__a;

			private double b;

			public double _003C_003E3__b;

			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CSamplesUnchecked_003Ed__44(int _003C_003E1__state)
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
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
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

		private readonly int _n;

		private readonly double _a;

		private readonly double _b;

		public int N => 0;

		public double A => 0.0;

		public double B => 0.0;

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

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double StdDev => 0.0;

		private double MathNet_002ENumerics_002EDistributions_002EIUnivariateDistribution_002EEntropy => 0.0;

		public double Skewness => 0.0;

		private int MathNet_002ENumerics_002EDistributions_002EIDiscreteDistribution_002EMode => 0;

		private double MathNet_002ENumerics_002EDistributions_002EIUnivariateDistribution_002EMedian => 0.0;

		public int Minimum => 0;

		public int Maximum => 0;

		public BetaBinomial(int n, double a, double b)
		{
		}

		public BetaBinomial(int n, double a, double b, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(int n, double a, double b)
		{
			return false;
		}

		public static bool IsValidParameterSet(int n, double a, double b, int k)
		{
			return false;
		}

		public double Probability(int k)
		{
			return 0.0;
		}

		public double ProbabilityLn(int k)
		{
			return 0.0;
		}

		public double CumulativeDistribution(double x)
		{
			return 0.0;
		}

		public static double PMF(int n, double a, double b, int k)
		{
			return 0.0;
		}

		public static double PMFLn(int n, double a, double b, int k)
		{
			return 0.0;
		}

		public static double CDF(int n, double a, double b, int x)
		{
			return 0.0;
		}

		private static int SampleUnchecked(System.Random rnd, int n, double a, double b)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, int n, double a, double b)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__44))]
		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, int n, double a, double b)
		{
			return null;
		}

		public int Sample()
		{
			return 0;
		}

		public void Samples(int[] values)
		{
		}

		public IEnumerable<int> Samples()
		{
			return null;
		}

		public int Sample(System.Random rnd, int n, double a, double b)
		{
			return 0;
		}

		public void Samples(System.Random rnd, int[] values, int n, double a, double b)
		{
		}

		public IEnumerable<int> Samples(int n, double a, double b)
		{
			return null;
		}

		public void Samples(int[] values, int n, double a, double b)
		{
		}
	}
}
