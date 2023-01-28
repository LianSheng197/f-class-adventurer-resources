using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Statistics
{
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public class RunningWeightedStatistics
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

		[DataMember(Order = 8)]
		private double _w1;

		[DataMember(Order = 9)]
		private double _w2;

		[DataMember(Order = 10)]
		private double _w3;

		[DataMember(Order = 11)]
		private double _w4;

		[DataMember(Order = 12)]
		private double _den;

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

		public double TotalWeight => 0.0;

		public double EffectiveSampleSize => 0.0;

		public RunningWeightedStatistics()
		{
		}

		public RunningWeightedStatistics(IEnumerable<Tuple<double, double>> values)
		{
		}

		public void Push(double weight, double value)
		{
		}

		public void PushRange(IEnumerable<Tuple<double, double>> values)
		{
		}

		public void PushRange(IEnumerable<double> weights, IEnumerable<double> values)
		{
		}

		public static RunningWeightedStatistics Combine(RunningWeightedStatistics a, RunningWeightedStatistics b)
		{
			return null;
		}

		public static RunningWeightedStatistics operator +(RunningWeightedStatistics a, RunningWeightedStatistics b)
		{
			return null;
		}
	}
}
