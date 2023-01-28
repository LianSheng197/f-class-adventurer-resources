using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class Exponential : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly double _rate;

		public double Rate => 0.0;

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

		public Exponential(double rate)
		{
		}

		public Exponential(double rate, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double rate)
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

		private static double SampleUnchecked(System.Random rnd, double rate)
		{
			return 0.0;
		}

		internal static void SamplesUnchecked(System.Random rnd, double[] values, double rate)
		{
		}

		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double rate)
		{
			return null;
		}

		public static double PDF(double rate, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double rate, double x)
		{
			return 0.0;
		}

		public static double CDF(double rate, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double rate, double p)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double rate)
		{
			return 0.0;
		}

		public static void Samples(System.Random rnd, double[] values, double rate)
		{
		}

		public static IEnumerable<double> Samples(System.Random rnd, double rate)
		{
			return null;
		}

		public static double Sample(double rate)
		{
			return 0.0;
		}

		public static void Samples(double[] values, double rate)
		{
		}

		public static IEnumerable<double> Samples(double rate)
		{
			return null;
		}
	}
}
