using System.Collections.Generic;

namespace MathNet.Numerics.Statistics
{
	public class MovingStatistics
	{
		private readonly double[] _oldValues;

		private readonly int _windowSize;

		private long _count;

		private long _totalCountOffset;

		private int _lastIndex;

		private int _lastNaNTimeToLive;

		private int _lastPosInfTimeToLive;

		private int _lastNegInfTimeToLive;

		private double _m1;

		private double _m2;

		private double _max;

		private double _min;

		public int WindowSize => 0;

		public long Count => 0L;

		public double Minimum => 0.0;

		public double Maximum => 0.0;

		public double Mean => 0.0;

		public double Variance => 0.0;

		public double PopulationVariance => 0.0;

		public double StandardDeviation => 0.0;

		public double PopulationStandardDeviation => 0.0;

		public MovingStatistics(int windowSize)
		{
		}

		public MovingStatistics(int windowSize, IEnumerable<double> values)
		{
		}

		public void Push(double value)
		{
		}

		public void PushRange(IEnumerable<double> values)
		{
		}

		private void DecrementTimeToLive()
		{
		}

		private void Reset(double min, double max)
		{
		}
	}
}
