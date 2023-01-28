using System.Numerics;

namespace MathNet.Numerics.Statistics
{
	public static class ArrayStatistics
	{
		public static Complex MinimumMagnitudePhase(Complex[] data)
		{
			return default(Complex);
		}

		public static Complex32 MinimumMagnitudePhase(Complex32[] data)
		{
			return default(Complex32);
		}

		public static Complex MaximumMagnitudePhase(Complex[] data)
		{
			return default(Complex);
		}

		public static Complex32 MaximumMagnitudePhase(Complex32[] data)
		{
			return default(Complex32);
		}

		public static double Minimum(double[] data)
		{
			return 0.0;
		}

		public static double Maximum(double[] data)
		{
			return 0.0;
		}

		public static double MinimumAbsolute(double[] data)
		{
			return 0.0;
		}

		public static double MaximumAbsolute(double[] data)
		{
			return 0.0;
		}

		public static double Mean(double[] data)
		{
			return 0.0;
		}

		public static double GeometricMean(double[] data)
		{
			return 0.0;
		}

		public static double HarmonicMean(double[] data)
		{
			return 0.0;
		}

		public static double Variance(double[] samples)
		{
			return 0.0;
		}

		public static double PopulationVariance(double[] population)
		{
			return 0.0;
		}

		public static double StandardDeviation(double[] samples)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(double[] population)
		{
			return 0.0;
		}

		public static (double, double) MeanVariance(double[] samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(double[] samples)
		{
			return default((double, double));
		}

		public static double Covariance(double[] samples1, double[] samples2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(double[] population1, double[] population2)
		{
			return 0.0;
		}

		public static double RootMeanSquare(double[] data)
		{
			return 0.0;
		}

		public static double OrderStatisticInplace(double[] data, int order)
		{
			return 0.0;
		}

		public static double MedianInplace(double[] data)
		{
			return 0.0;
		}

		public static double PercentileInplace(double[] data, int p)
		{
			return 0.0;
		}

		public static double LowerQuartileInplace(double[] data)
		{
			return 0.0;
		}

		public static double UpperQuartileInplace(double[] data)
		{
			return 0.0;
		}

		public static double InterquartileRangeInplace(double[] data)
		{
			return 0.0;
		}

		public static double[] FiveNumberSummaryInplace(double[] data)
		{
			return null;
		}

		public static double QuantileInplace(double[] data, double tau)
		{
			return 0.0;
		}

		public static double QuantileCustomInplace(double[] data, double tau, double a, double b, double c, double d)
		{
			return 0.0;
		}

		public static double QuantileCustomInplace(double[] data, double tau, QuantileDefinition definition)
		{
			return 0.0;
		}

		private static double SelectInplace(double[] workingData, int rank)
		{
			return 0.0;
		}

		public static double[] RanksInplace(double[] data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		private static void RanksTies(double[] ranks, int[] index, int a, int b, RankDefinition definition)
		{
		}

		public static double Mean(int[] data)
		{
			return 0.0;
		}

		public static double GeometricMean(int[] data)
		{
			return 0.0;
		}

		public static double HarmonicMean(int[] data)
		{
			return 0.0;
		}

		public static double Variance(int[] samples)
		{
			return 0.0;
		}

		public static double PopulationVariance(int[] population)
		{
			return 0.0;
		}

		public static double StandardDeviation(int[] samples)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(int[] population)
		{
			return 0.0;
		}

		public static (double, double) MeanVariance(int[] samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(int[] samples)
		{
			return default((double, double));
		}

		public static double Covariance(int[] samples1, int[] samples2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(int[] population1, int[] population2)
		{
			return 0.0;
		}

		public static double RootMeanSquare(int[] data)
		{
			return 0.0;
		}

		public static float Minimum(float[] data)
		{
			return 0f;
		}

		public static float Maximum(float[] data)
		{
			return 0f;
		}

		public static float MinimumAbsolute(float[] data)
		{
			return 0f;
		}

		public static float MaximumAbsolute(float[] data)
		{
			return 0f;
		}

		public static double Mean(float[] data)
		{
			return 0.0;
		}

		public static double GeometricMean(float[] data)
		{
			return 0.0;
		}

		public static double HarmonicMean(float[] data)
		{
			return 0.0;
		}

		public static double Variance(float[] samples)
		{
			return 0.0;
		}

		public static double PopulationVariance(float[] population)
		{
			return 0.0;
		}

		public static double StandardDeviation(float[] samples)
		{
			return 0.0;
		}

		public static double PopulationStandardDeviation(float[] population)
		{
			return 0.0;
		}

		public static (double, double) MeanVariance(float[] samples)
		{
			return default((double, double));
		}

		public static (double, double) MeanStandardDeviation(float[] samples)
		{
			return default((double, double));
		}

		public static double Covariance(float[] samples1, float[] samples2)
		{
			return 0.0;
		}

		public static double PopulationCovariance(float[] population1, float[] population2)
		{
			return 0.0;
		}

		public static double RootMeanSquare(float[] data)
		{
			return 0.0;
		}

		public static float OrderStatisticInplace(float[] data, int order)
		{
			return 0f;
		}

		public static float MedianInplace(float[] data)
		{
			return 0f;
		}

		public static float PercentileInplace(float[] data, int p)
		{
			return 0f;
		}

		public static float LowerQuartileInplace(float[] data)
		{
			return 0f;
		}

		public static float UpperQuartileInplace(float[] data)
		{
			return 0f;
		}

		public static float InterquartileRangeInplace(float[] data)
		{
			return 0f;
		}

		public static float[] FiveNumberSummaryInplace(float[] data)
		{
			return null;
		}

		public static float QuantileInplace(float[] data, double tau)
		{
			return 0f;
		}

		public static float QuantileCustomInplace(float[] data, double tau, double a, double b, double c, double d)
		{
			return 0f;
		}

		public static float QuantileCustomInplace(float[] data, double tau, QuantileDefinition definition)
		{
			return 0f;
		}

		private static float SelectInplace(float[] workingData, int rank)
		{
			return 0f;
		}

		public static float[] RanksInplace(float[] data, RankDefinition definition = RankDefinition.Average)
		{
			return null;
		}

		private static void RanksTies(float[] ranks, int[] index, int a, int b, RankDefinition definition)
		{
		}
	}
}
