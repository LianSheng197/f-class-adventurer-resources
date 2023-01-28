using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Statistics
{
	public static class Correlation
	{
		public static double[] Auto(double[] x)
		{
			return null;
		}

		public static double[] Auto(double[] x, int kMax, int kMin = 0)
		{
			return null;
		}

		public static double[] Auto(double[] x, int[] k)
		{
			return null;
		}

		private static double[] AutoCorrelationFft(double[] x, int kLow, int kHigh)
		{
			return null;
		}

		public static double Pearson(IEnumerable<double> dataA, IEnumerable<double> dataB)
		{
			return 0.0;
		}

		public static double WeightedPearson(IEnumerable<double> dataA, IEnumerable<double> dataB, IEnumerable<double> weights)
		{
			return 0.0;
		}

		public static Matrix<double> PearsonMatrix(params double[][] vectors)
		{
			return null;
		}

		public static Matrix<double> PearsonMatrix(IEnumerable<double[]> vectors)
		{
			return null;
		}

		public static double Spearman(IEnumerable<double> dataA, IEnumerable<double> dataB)
		{
			return 0.0;
		}

		public static Matrix<double> SpearmanMatrix(params double[][] vectors)
		{
			return null;
		}

		public static Matrix<double> SpearmanMatrix(IEnumerable<double[]> vectors)
		{
			return null;
		}

		private static double[] Rank(IEnumerable<double> series)
		{
			return null;
		}
	}
}
