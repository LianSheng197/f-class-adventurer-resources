using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Statistics
{
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public class DescriptiveStatistics
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

		public DescriptiveStatistics(IEnumerable<double> data, bool increasedAccuracy = false)
		{
		}

		public DescriptiveStatistics(IEnumerable<double?> data, bool increasedAccuracy = false)
		{
		}

		private void Compute(IEnumerable<double> data)
		{
		}

		private void Compute(IEnumerable<double?> data)
		{
		}

		private void ComputeDecimal(IEnumerable<double> data)
		{
		}

		private void ComputeDecimal(IEnumerable<double?> data)
		{
		}

		private void SetStatistics(double mean, double variance, double skewness, double kurtosis, double minimum, double maximum, long n)
		{
		}
	}
}
