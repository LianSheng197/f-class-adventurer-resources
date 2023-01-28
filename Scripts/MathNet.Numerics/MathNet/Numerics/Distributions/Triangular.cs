using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class Triangular : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly double _lower;

		private readonly double _upper;

		private readonly double _mode;

		public double LowerBound => 0.0;

		public double UpperBound => 0.0;

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

		public double Mode => 0.0;

		public double Median => 0.0;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public Triangular(double lower, double upper, double mode)
		{
		}

		public Triangular(double lower, double upper, double mode, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double lower, double upper, double mode)
		{
			return false;
		}

		public double Density(double x)
		{
			return 0.0;
		}

		public double DensityLn(double x)
		{
			return 0.0;
		}

		public double CumulativeDistribution(double x)
		{
			return 0.0;
		}

		public double InverseCumulativeDistribution(double p)
		{
			return 0.0;
		}

		public double Sample()
		{
			return 0.0;
		}

		public void Samples(double[] values)
		{
		}

		public IEnumerable<double> Samples()
		{
			return null;
		}

		private static double SampleUnchecked(System.Random rnd, double lower, double upper, double mode)
		{
			return 0.0;
		}

		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double lower, double upper, double mode)
		{
			return null;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double lower, double upper, double mode)
		{
		}

		public static double PDF(double lower, double upper, double mode, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double lower, double upper, double mode, double x)
		{
			return 0.0;
		}

		public static double CDF(double lower, double upper, double mode, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double lower, double upper, double mode, double p)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double lower, double upper, double mode)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double lower, double upper, double mode)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double lower, double upper, double mode)
		{
		}

		public static double Sample(double lower, double upper, double mode)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double lower, double upper, double mode)
		{
			return null;
		}

		public static void Samples(double[] values, double lower, double upper, double mode)
		{
		}
	}
}
