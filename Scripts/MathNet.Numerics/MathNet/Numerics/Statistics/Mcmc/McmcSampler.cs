using System;

namespace MathNet.Numerics.Statistics.Mcmc
{
	public abstract class McmcSampler<T>
	{
		private System.Random _randomNumberGenerator;

		protected int Accepts;

		protected int Samples;

		public System.Random RandomSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double AcceptanceRate => 0.0;

		public abstract T Sample();

		public virtual T[] Sample(int n)
		{
			return null;
		}
	}
}
