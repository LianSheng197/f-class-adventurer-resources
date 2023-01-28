using System;
using System.Collections.Generic;
using System.Numerics;

namespace MathNet.Numerics.Statistics
{
	public static class Statistics
	{
		public static double Minimum(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float Minimum(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double Minimum(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double Maximum(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float Maximum(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double Maximum(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double MinimumAbsolute(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float MinimumAbsolute(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double MaximumAbsolute(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float MaximumAbsolute(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static Complex MinimumMagnitudePhase(this IEnumerable<Complex> data)
		{
			return default(Complex);
		}

		public static Complex32 MinimumMagnitudePhase(this IEnumerable<Complex32> data)
		{
			return default(Complex32);
		}

		public static Complex MaximumMagnitudePhase(this IEnumerable<Complex> data)
		{
			return default(Complex);
		}

		public static Complex32 MaximumMagnitudePhase(this IEnumerable<Complex32> data)
		{
			return default(Complex32);
		}

		public static double Mean(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double Mean(this IEnumerable<float> data)
		{
			return 0.0;
		}

		public static double Mean(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double GeometricMean(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double GeometricMean(this IEnumerable<float> data)
		{
			return 0.0;
		}

		public static double HarmonicMean(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double HarmonicMean(this IEnumerable<float> data)
		{
			return 0.0;
		}

		public static double Variance(this IEnumerable<double> samples)
		{
			return 0.0;
		}

		public static double Variance(this IEnumerable<float> samples)
		{
			return 0.0;
		}

		public static double Variance(this IEnumerable<double?> samples)
		{
			return 0.0;
		}

		public static double PopulationVariance(this IEnumerable<double> population)
		{
			return 0.0;
		}

		public static double PopulationVariance(this IEnumerable<float> population)
		{
			return 0.0;
		}

		public static double PopulationVariance(this IEnumerable<double?> population)
		{
			return 0.0;
		}

		public static double StandardDeviation(this IEnumerable<double> samples)
		{
			return 0.0;
		}

		public static double StandardDeviation(this IEnumerable<float> samples)
		{
			return 0.0;
		}

		public static double StandardDeviation(this IEnumerable<double?> samples)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(this IEnumerable<double> population)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(this IEnumerable<float> population)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(this IEnumerable<double?> population)
		{
			return 0.0;
		}

		public static double Skewness(this IEnumerable<double> samples)
		{
			return 0.0;
		}

		public static double Skewness(this IEnumerable<double?> samples)
		{
			return 0.0;
		}

		public static double PopulationSkewness(this IEnumerable<double> population)
		{
			return 0.0;
		}

		public static double PopulationSkewness(this IEnumerable<double?> population)
		{
			return 0.0;
		}

		public static double Kurtosis(this IEnumerable<double> samples)
		{
			return 0.0;
		}

		public static double Kurtosis(this IEnumerable<double?> samples)
		{
			return 0.0;
		}

		public static double PopulationKurtosis(this IEnumerable<double> population)
		{
			return 0.0;
		}

		public static double PopulationKurtosis(this IEnumerable<double?> population)
		{
			return 0.0;
		}

		public static (double, double) MeanVariance(this IEnumerable<double> samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanVariance(this IEnumerable<float> samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(this IEnumerable<double> samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(this IEnumerable<float> samples)
		{
			return default((double, double));
		}

		public static (double, double) SkewnessKurtosis(this IEnumerable<double> samples)
		{
			return default((double, double));
		}

		public static (double, double) PopulationSkewnessKurtosis(this IEnumerable<double> population)
		{
			return default((double, double));
		}

		public static double Covariance(this IEnumerable<double> samples1, IEnumerable<double> samples2)
		{
			return 0.0;
		}

		public static double Covariance(this IEnumerable<float> samples1, IEnumerable<float> samples2)
		{
			return 0.0;
		}

		public static double Covariance(this IEnumerable<double?> samples1, IEnumerable<double?> samples2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(this IEnumerable<double> population1, IEnumerable<double> population2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(this IEnumerable<float> population1, IEnumerable<float> population2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(this IEnumerable<double?> population1, IEnumerable<double?> population2)
		{
			return 0.0;
		}

		public static double RootMeanSquare(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double RootMeanSquare(this IEnumerable<float> data)
		{
			return 0.0;
		}

		public static double RootMeanSquare(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double Median(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float Median(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double Median(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double Quantile(this IEnumerable<double> data, double tau)
		{
			return 0.0;
		}

		public static float Quantile(this IEnumerable<float> data, double tau)
		{
			return 0f;
		}

		public static double Quantile(this IEnumerable<double?> data, double tau)
		{
			return 0.0;
		}

		public static Func<double, double> QuantileFunc(this IEnumerable<double> data)
		{
			return null;
		}

		public static Func<float, float> QuantileFunc(this IEnumerable<float> data)
		{
			return null;
		}

		public static Func<double, double> QuantileFunc(this IEnumerable<double?> data)
		{
			return null;
		}

		public static double QuantileCustom(this IEnumerable<double> data, double tau, QuantileDefinition definition)
		{
			return 0.0;
		}

		public static float QuantileCustom(this IEnumerable<float> data, double tau, QuantileDefinition definition)
		{
			return 0f;
		}

		public static double QuantileCustom(this IEnumerable<double?> data, double tau, QuantileDefinition definition)
		{
			return 0.0;
		}

		public static Func<double, double> QuantileCustomFunc(this IEnumerable<double> data, QuantileDefinition definition)
		{
			return null;
		}

		public static Func<float, float> QuantileCustomFunc(this IEnumerable<float> data, QuantileDefinition definition)
		{
			return null;
		}

		public static Func<double, double> QuantileCustomFunc(this IEnumerable<double?> data, QuantileDefinition definition)
		{
			return null;
		}

		public static double Percentile(this IEnumerable<double> data, int p)
		{
			return 0.0;
		}

		public static float Percentile(this IEnumerable<float> data, int p)
		{
			return 0f;
		}

		public static double Percentile(this IEnumerable<double?> data, int p)
		{
			return 0.0;
		}

		public static Func<int, double> PercentileFunc(this IEnumerable<double> data)
		{
			return null;
		}

		public static Func<int, float> PercentileFunc(this IEnumerable<float> data)
		{
			return null;
		}

		public static Func<int, double> PercentileFunc(this IEnumerable<double?> data)
		{
			return null;
		}

		public static double LowerQuartile(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float LowerQuartile(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double LowerQuartile(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double UpperQuartile(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float UpperQuartile(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double UpperQuartile(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double InterquartileRange(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static float InterquartileRange(this IEnumerable<float> data)
		{
			return 0f;
		}

		public static double InterquartileRange(this IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static double[] FiveNumberSummary(this IEnumerable<double> data)
		{
			return null;
		}

		public static float[] FiveNumberSummary(this IEnumerable<float> data)
		{
			return null;
		}

		public static double[] FiveNumberSummary(this IEnumerable<double?> data)
		{
			return null;
		}

		public static double OrderStatistic(IEnumerable<double> data, int order)
		{
			return 0.0;
		}

		public static float OrderStatistic(IEnumerable<float> data, int order)
		{
			return 0f;
		}

		public static Func<int, double> OrderStatisticFunc(IEnumerable<double> data)
		{
			return null;
		}

		public static Func<int, float> OrderStatisticFunc(IEnumerable<float> data)
		{
			return null;
		}

		public static double[] Ranks(this IEnumerable<double> data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		public static float[] Ranks(this IEnumerable<float> data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		public static double[] Ranks(this IEnumerable<double?> data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		public static double QuantileRank(this IEnumerable<double> data, double x, RankDefinition definition = RankDefinition.Average)
		{
			return 0.0;
		}

		public static double QuantileRank(this IEnumerable<float> data, float x, RankDefinition definition = RankDefinition.Average)
		{
			return 0.0;
		}

		public static double QuantileRank(this IEnumerable<double?> data, double x, RankDefinition definition = RankDefinition.Average)
		{
			return 0.0;
		}

		public static Func<double, double> QuantileRankFunc(this IEnumerable<double> data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		public static Func<float, double> QuantileRankFunc(this IEnumerable<float> data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		public static Func<double, double> QuantileRankFunc(this IEnumerable<double?> data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		public static double EmpiricalCDF(this IEnumerable<double> data, double x)
		{
			return 0.0;
		}

		public static double EmpiricalCDF(this IEnumerable<float> data, float x)
		{
			return 0.0;
		}

		public static double EmpiricalCDF(this IEnumerable<double?> data, double x)
		{
			return 0.0;
		}

		public static Func<double, double> EmpiricalCDFFunc(this IEnumerable<double> data)
		{
			return null;
		}

		public static Func<float, double> EmpiricalCDFFunc(this IEnumerable<float> data)
		{
			return null;
		}

		public static Func<double, double> EmpiricalCDFFunc(this IEnumerable<double?> data)
		{
			return null;
		}

		public static double EmpiricalInvCDF(this IEnumerable<double> data, double tau)
		{
			return 0.0;
		}

		public static float EmpiricalInvCDF(this IEnumerable<float> data, double tau)
		{
			return 0f;
		}

		public static double EmpiricalInvCDF(this IEnumerable<double?> data, double tau)
		{
			return 0.0;
		}

		public static Func<double, double> EmpiricalInvCDFFunc(this IEnumerable<double> data)
		{
			return null;
		}

		public static Func<double, float> EmpiricalInvCDFFunc(this IEnumerable<float> data)
		{
			return null;
		}

		public static Func<double, double> EmpiricalInvCDFFunc(this IEnumerable<double?> data)
		{
			return null;
		}

		public static double Entropy(IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double Entropy(IEnumerable<double?> data)
		{
			return 0.0;
		}

		public static IEnumerable<double> MovingAverage(this IEnumerable<double> samples, int windowSize)
		{
			return null;
		}
	}
}
