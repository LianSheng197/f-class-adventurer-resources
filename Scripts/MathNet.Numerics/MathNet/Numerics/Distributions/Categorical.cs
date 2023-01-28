using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MathNet.Numerics.Statistics;

namespace MathNet.Numerics.Distributions
{
	public class Categorical : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		[CompilerGenerated]
		private sealed class _003CSamplesUnchecked_003Ed__44 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private System.Random rnd;

			public System.Random _003C_003E3__rnd;

			private double[] cdfUnnormalized;

			public double[] _003C_003E3__cdfUnnormalized;

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

		private readonly double[] _pmfNormalized;

		private readonly double[] _cdfUnnormalized;

		public double[] P => null;

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

		public double StdDev => 0.0;

		public double Variance => 0.0;

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public int Minimum => 0;

		public int Maximum => 0;

		public int Mode => 0;

		public double Median => 0.0;

		public Categorical(double[] probabilityMass)
		{
		}

		public Categorical(double[] probabilityMass, System.Random randomSource)
		{
		}

		public Categorical(Histogram histogram)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidProbabilityMass(double[] p)
		{
			return false;
		}

		public static bool IsValidCumulativeDistribution(double[] cdf)
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

		public int InverseCumulativeDistribution(double probability)
		{
			return 0;
		}

		public static double PMF(double[] probabilityMass, int k)
		{
			return 0.0;
		}

		public static double PMFLn(double[] probabilityMass, int k)
		{
			return 0.0;
		}

		public static double CDF(double[] probabilityMass, double x)
		{
			return 0.0;
		}

		public static int InvCDF(double[] probabilityMass, double probability)
		{
			return 0;
		}

		public static int InvCDFWithCumulativeDistribution(double[] cdfUnnormalized, double probability)
		{
			return 0;
		}

		internal static double[] ProbabilityMassToCumulativeDistribution(double[] probabilityMass)
		{
			return null;
		}

		internal static int SampleUnchecked(System.Random rnd, double[] cdfUnnormalized)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, double[] cdfUnnormalized)
		{
		}

		[IteratorStateMachine(typeof(_003CSamplesUnchecked_003Ed__44))]
		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, double[] cdfUnnormalized)
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

		public static int Sample(System.Random rnd, double[] probabilityMass)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(System.Random rnd, double[] probabilityMass)
		{
			return null;
		}

		public static void Samples(System.Random rnd, int[] values, double[] probabilityMass)
		{
		}

		public static int Sample(double[] probabilityMass)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(double[] probabilityMass)
		{
			return null;
		}

		public static void Samples(int[] values, double[] probabilityMass)
		{
		}

		public static int SampleWithCumulativeDistribution(System.Random rnd, double[] cdfUnnormalized)
		{
			return 0;
		}

		public static IEnumerable<int> SamplesWithCumulativeDistribution(System.Random rnd, double[] cdfUnnormalized)
		{
			return null;
		}

		public static void SamplesWithCumulativeDistribution(System.Random rnd, int[] values, double[] cdfUnnormalized)
		{
		}

		public static int SampleWithCumulativeDistribution(double[] cdfUnnormalized)
		{
			return 0;
		}

		public static IEnumerable<int> SamplesWithCumulativeDistribution(double[] cdfUnnormalized)
		{
			return null;
		}

		public static void SamplesWithCumulativeDistribution(int[] values, double[] cdfUnnormalized)
		{
		}
	}
}
