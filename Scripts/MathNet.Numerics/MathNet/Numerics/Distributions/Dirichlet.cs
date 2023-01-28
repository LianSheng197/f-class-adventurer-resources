using System;

namespace MathNet.Numerics.Distributions
{
	public class Dirichlet : IDistribution
	{
		private System.Random _random;

		private readonly double[] _alpha;

		public double[] Alpha => null;

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

		public int Dimension => 0;

		private double AlphaSum => 0.0;

		public double[] Mean => null;

		public double[] Variance => null;

		public double Entropy => 0.0;

		public Dirichlet(double[] alpha)
		{
		}

		public Dirichlet(double[] alpha, System.Random randomSource)
		{
		}

		public Dirichlet(double alpha, int k)
		{
		}

		public Dirichlet(double alpha, int k, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double[] alpha)
		{
			return false;
		}

		public double Density(double[] x)
		{
			return 0.0;
		}

		public double DensityLn(double[] x)
		{
			return 0.0;
		}

		public double[] Sample()
		{
			return null;
		}

		public static double[] Sample(System.Random rnd, double[] alpha)
		{
			return null;
		}
	}
}
