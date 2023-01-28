using System;
using System.Collections.Generic;

namespace MathNet.Numerics.Distributions
{
	public class LogNormal : IContinuousDistribution, IUnivariateDistribution, IDistribution
	{
		private System.Random _random;

		private readonly double _mu;

		private readonly double _sigma;

		public double Mu => 0.0;

		public double Sigma => 0.0;

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

		public LogNormal(double mu, double sigma)
		{
		}

		public LogNormal(double mu, double sigma, System.Random randomSource)
		{
		}

		public static LogNormal WithMuSigma(double mu, double sigma, System.Random randomSource = null)
		{
			return null;
		}

		public static LogNormal WithMeanVariance(double mean, double var, System.Random randomSource = null)
		{
			return null;
		}

		public static LogNormal Estimate(IEnumerable<double> samples, System.Random randomSource = null)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double mu, double sigma)
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

		private static double SampleUnchecked(System.Random rnd, double mu, double sigma)
		{
			return 0.0;
		}

		private static IEnumerable<double> SamplesUnchecked(System.Random rnd, double mu, double sigma)
		{
			return null;
		}

		private static void SamplesUnchecked(System.Random rnd, double[] values, double mu, double sigma)
		{
		}

		public static double PDF(double mu, double sigma, double x)
		{
			return 0.0;
		}

		public static double PDFLn(double mu, double sigma, double x)
		{
			return 0.0;
		}

		public static double CDF(double mu, double sigma, double x)
		{
			return 0.0;
		}

		public static double InvCDF(double mu, double sigma, double p)
		{
			return 0.0;
		}

		public static double Sample(System.Random rnd, double mu, double sigma)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(System.Random rnd, double mu, double sigma)
		{
			return null;
		}

		public static void Samples(System.Random rnd, double[] values, double mu, double sigma)
		{
		}

		public static double Sample(double mu, double sigma)
		{
			return 0.0;
		}

		public static IEnumerable<double> Samples(double mu, double sigma)
		{
			return null;
		}

		public static void Samples(double[] values, double mu, double sigma)
		{
		}
	}
}
