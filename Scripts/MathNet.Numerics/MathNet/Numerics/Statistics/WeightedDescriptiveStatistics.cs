using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Statistics
{
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public class WeightedDescriptiveStatistics
	{
		[DataMember(Order = 1)]
		public long Count
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 2)]
		public double Mean
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 3)]
		public double Variance
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 4)]
		public double StandardDeviation
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 5)]
		public double Skewness
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 6)]
		public double Kurtosis
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 7)]
		public double Maximum
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 8)]
		public double Minimum
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 9)]
		public double TotalWeight
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DataMember(Order = 10)]
		public double EffectiveSampleSize
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WeightedDescriptiveStatistics(IEnumerable<Tuple<double, double>> data, bool increasedAccuracy = false)
		{
		}

		public WeightedDescriptiveStatistics(IEnumerable<(double, double)> data, bool increasedAccuracy = false)
		{
		}

		private void Compute(IEnumerable<(double, double)> data)
		{
		}

		private void ComputeDecimal(IEnumerable<(double, double)> data)
		{
		}

		private void SetStatisticsWeighted(double mean, double variance, double skewness, double kurtosis, double minimum, double maximum, long n, double w1, double den, double w2, double w3, double w4)
		{
		}
	}
}
