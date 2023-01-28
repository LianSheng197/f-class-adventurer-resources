using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace MathNet.Numerics.Statistics
{
	[Serializable]
	[DataContract(Namespace = "urn:MathNet/Numerics")]
	[DefaultMember("Item")]
	public class Histogram
	{
		[DataMember(Order = 1)]
		private readonly List<Bucket> _buckets;

		[DataMember(Order = 2)]
		private bool _areBucketsSorted;

		public double LowerBound => 0.0;

		public double UpperBound => 0.0;

		public Bucket Item => null;

		public int BucketCount => 0;

		public double DataCount => 0.0;

		public Histogram()
		{
		}

		public Histogram(IEnumerable<double> data, int nbuckets)
		{
		}

		public Histogram(IEnumerable<double> data, int nbuckets, double lower, double upper)
		{
		}

		public void AddData(double d)
		{
		}

		public void AddData(IEnumerable<double> data)
		{
		}

		public void AddBucket(Bucket bucket)
		{
		}

		private void LazySort()
		{
		}

		public Bucket GetBucketOf(double v)
		{
			return null;
		}

		public int GetBucketIndexOf(double v)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
