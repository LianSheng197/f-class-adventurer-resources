using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Statistics
{
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public class RunningStatistics
	{
		[DataMember(Order = 1)]
		private long _n;

		[DataMember(Order = 2)]
		private double _min;

		[DataMember(Order = 3)]
		private double _max;

		[DataMember(Order = 4)]
		private double _m1;

		[DataMember(Order = 5)]
		private double _m2;

		[DataMember(Order = 6)]
		private double _m3;

		[DataMember(Order = 7)]
		private double _m4;

		public long Count => 0L;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double PopulationVariance => 0.0;

		public double StandardDeviation => 0.0;

		public double PopulationStandardDeviation => 0.0;

		public double Skewness => 0.0;

		public double PopulationSkewness => 0.0;

		public double Kurtosis => 0.0;

		public double PopulationKurtosis => 0.0;

		public RunningStatistics()
		{
		}

		public RunningStatistics(IEnumerable<double> values)
		{
		}

		public void Push(double value)
		{
		}

		public void PushRange(IEnumerable<double> values)
		{
		}

		public static RunningStatistics Combine(RunningStatistics a, RunningStatistics b)
		{
			return null;
		}

		public static RunningStatistics operator +(RunningStatistics a, RunningStatistics b)
		{
			return null;
		}
	}
}
