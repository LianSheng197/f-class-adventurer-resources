using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class Pareto : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly double _scale;

		private readonly double _shape;

		public double Scale => 0.0;

		public double Shape => 0.0;

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

		public Pareto(double scale, double shape)
		{
		}

		public Pareto(double scale, double shape, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double scale, double shape)
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

		private static double SampleUnchecked(System.Random rnd, double scale, double shape)
		{
			return 0.0;
		}

		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double scale, double shape)
		{
			return null;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double scale, double shape)
		{
		}

		public static double PDF(double scale, double shape, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double scale, double shape, double x)
		{
			return 0.0;
		}

		public static double CDF(double scale, double shape, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double scale, double shape, double p)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double scale, double shape)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double scale, double shape)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double scale, double shape)
		{
		}

		public static double Sample(double scale, double shape)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double scale, double shape)
		{
			return null;
		}

		public static void Samples(double[] values, double scale, double shape)
		{
		}
	}
}
