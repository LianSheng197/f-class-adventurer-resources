using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Statistics
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	public class Bucket : IComparable<Bucket>, ICloneable
	{
		private sealed class PointComparer : IComparer<Bucket>
		{
			public int Compare(Bucket bkt1, Bucket bkt2)
			{
				return 0;
			}
		}

		private static readonly PointComparer Comparer;

		[DataMember(Order = 1)]
		public double LowerBound
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(Order = 2)]
		public double UpperBound
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DataMember(Order = 3)]
		public double Count
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public double Width => 0.0;

		private bool IsSinglePoint => false;

		public static IComparer<Bucket> DefaultPointComparer => null;

		public Bucket(double lowerBound, double upperBound, double count = 0.0)
		{
		}

		public Bucket(double targetValue)
		{
		}

		public object Clone()
		{
			return null;
		}

		public int Contains(double x)
		{
			return 0;
		}

		public int CompareTo(Bucket bucket)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
