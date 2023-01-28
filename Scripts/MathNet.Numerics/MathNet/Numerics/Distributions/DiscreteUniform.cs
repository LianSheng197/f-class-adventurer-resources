using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class DiscreteUniform : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly int _lower;

		private readonly int _upper;

		public int LowerBound => 0;

		public int UpperBound => 0;

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

		public DiscreteUniform(int lower, int upper)
		{
		}

		public DiscreteUniform(int lower, int upper, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(int lower, int upper)
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

		public static double PMF(int lower, int upper, int k)
		{
			return 0.0;
		}

		public static double PMFLn(int lower, int upper, int k)
		{
			return 0.0;
		}

		public static double CDF(int lower, int upper, double x)
		{
			return 0.0;
		}

		private static int SampleUnchecked(System.Random rnd, int lower, int upper)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, int lower, int upper)
		{
		}

		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, int lower, int upper)
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

		public static int Sample(System.Random rnd, int lower, int upper)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(System.Random rnd, int lower, int upper)
		{
			return null;
		}

		public static void Samples(System.Random rnd, int[] values, int lower, int upper)
		{
		}

		public static int Sample(int lower, int upper)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(int lower, int upper)
		{
			return null;
		}

		public static void Samples(int[] values, int lower, int upper)
		{
		}
	}
}
