using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class InverseGamma : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly double _shape;

		private readonly double _scale;

		public double Shape => 0.0;

		public double Scale => 0.0;

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

		public InverseGamma(double shape, double scale)
		{
		}

		public InverseGamma(double shape, double scale, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double shape, double scale)
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

		private static double SampleUnchecked(System.Random rnd, double shape, double scale)
		{
			return 0.0;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double shape, double scale)
		{
		}

		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double shape, double scale)
		{
			return null;
		}

		public static double PDF(double shape, double scale, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double shape, double scale, double x)
		{
			return 0.0;
		}

		public static double CDF(double shape, double scale, double x)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double shape, double scale)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double shape, double scale)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double shape, double scale)
		{
		}

		public static double Sample(double shape, double scale)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double shape, double scale)
		{
			return null;
		}

		public static void Samples(double[] values, double shape, double scale)
		{
		}
	}
}
