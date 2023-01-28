using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class Geometric : IDiscreteDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly double _p;

		public double P => 0.0;

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

		public double Entropy => 0.0;

		public double Skewness => 0.0;

		public int Mode => 0;

		public double Median => 0.0;

		public int Minimum => 0;

		public int Maximum => 0;

		public Geometric(double p)
		{
		}

		public Geometric(double p, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double p)
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

		public static double PMF(double p, int k)
		{
			return 0.0;
		}

		public static double PMFLn(double p, int k)
		{
			return 0.0;
		}

		public static double CDF(double p, double x)
		{
			return 0.0;
		}

		private static int SampleUnchecked(System.Random rnd, double p)
		{
			return 0;
		}

		private static void SamplesUnchecked(System.Random rnd, int[] values, double p)
		{
		}

		private static IEnumerable<int> SamplesUnchecked(System.Random rnd, double p)
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

		public static int Sample(System.Random rnd, double p)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(System.Random rnd, double p)
		{
			return null;
		}

		public static void Samples(System.Random rnd, int[] values, double p)
		{
		}

		public static int Sample(double p)
		{
			return 0;
		}

		public static IEnumerable<int> Samples(double p)
		{
			return null;
		}

		public static void Samples(int[] values, double p)
		{
		}
	}
}
