using System.Collections.Generic;

namespace MathNet.Numerics.Financial
{
	public static class AbsoluteRiskMeasures
	{
		public static double GainStandardDeviation(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double LossStandardDeviation(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double DownsideDeviation(this IEnumerable<double> data, double minimalAcceptableReturn)
		{
			return 0.0;
		}

		public static double SemiDeviation(this IEnumerable<double> data)
		{
			return 0.0;
		}

		public static double GainLossRatio(this IEnumerable<double> data)
		{
			return 0.0;
		}
	}
}
