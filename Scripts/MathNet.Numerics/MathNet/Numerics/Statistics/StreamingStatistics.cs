using System.Collections.Generic;
using System.Numerics;

namespace MathNet.Numerics.Statistics
{
	public static class StreamingStatistics
	{
		public static double Minimum(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static float Minimum(IEnumerable<float> stream)
		{
			return 0f;
		}

		public static double Maximum(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static float Maximum(IEnumerable<float> stream)
		{
			return 0f;
		}

		public static double MinimumAbsolute(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static float MinimumAbsolute(IEnumerable<float> stream)
		{
			return 0f;
		}

		public static double MaximumAbsolute(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static float MaximumAbsolute(IEnumerable<float> stream)
		{
			return 0f;
		}

		public static Complex MinimumMagnitudePhase(IEnumerable<Complex> stream)
		{
			return default(Complex);
		}

		public static Complex32 MinimumMagnitudePhase(IEnumerable<Complex32> stream)
		{
			return default(Complex32);
		}

		public static Complex MaximumMagnitudePhase(IEnumerable<Complex> stream)
		{
			return default(Complex);
		}

		public static Complex32 MaximumMagnitudePhase(IEnumerable<Complex32> stream)
		{
			return default(Complex32);
		}

		public static double Mean(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static double Mean(IEnumerable<float> stream)
		{
			return 0.0;
		}

		public static double GeometricMean(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static double GeometricMean(IEnumerable<float> stream)
		{
			return 0.0;
		}

		public static double HarmonicMean(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static double HarmonicMean(IEnumerable<float> stream)
		{
			return 0.0;
		}

		public static double Variance(IEnumerable<double> samples)
		{
			return 0.0;
		}

		public static double Variance(IEnumerable<float> samples)
		{
			return 0.0;
		}

		public static double PopulationVariance(IEnumerable<double> population)
		{
			return 0.0;
		}

		public static double PopulationVariance(IEnumerable<float> population)
		{
			return 0.0;
		}

		public static double StandardDeviation(IEnumerable<double> samples)
		{
			return 0.0;
		}

		public static double StandardDeviation(IEnumerable<float> samples)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(IEnumerable<double> population)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(IEnumerable<float> population)
		{
			return 0.0;
		}

		public static (double, double) MeanVariance(IEnumerable<double> samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanVariance(IEnumerable<float> samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(IEnumerable<double> samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(IEnumerable<float> samples)
		{
			return default((double, double));
		}

		public static double Covariance(IEnumerable<double> samples1, IEnumerable<double> samples2)
		{
			return 0.0;
		}

		public static double Covariance(IEnumerable<float> samples1, IEnumerable<float> samples2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(IEnumerable<double> population1, IEnumerable<double> population2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(IEnumerable<float> population1, IEnumerable<float> population2)
		{
			return 0.0;
		}

		public static double RootMeanSquare(IEnumerable<double> stream)
		{
			return 0.0;
		}

		public static double RootMeanSquare(IEnumerable<float> stream)
		{
			return 0.0;
		}

		public static double Entropy(IEnumerable<double> stream)
		{
			return 0.0;
		}
	}
}
