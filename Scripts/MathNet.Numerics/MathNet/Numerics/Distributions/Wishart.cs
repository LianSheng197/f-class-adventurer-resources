using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.Distributions
{
	public class Wishart : IDistribution
	{
		private System.Random _random;

		private readonly double _degreesOfFreedom;

		private readonly Matrix<double> _scale;

		private readonly Cholesky<double> _chol;

		public double DegreesOfFreedom => 0.0;

		public Matrix<double> Scale => null;

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

		public Matrix<double> Mean => null;

		public Matrix<double> Mode => null;

		public Matrix<double> Variance => null;

		public Wishart(double degreesOfFreedom, Matrix<double> scale)
		{
		}

		public Wishart(double degreesOfFreedom, Matrix<double> scale, System.Random randomSource)
		{
		}

		public static bool IsValidParameterSet(double degreesOfFreedom, Matrix<double> scale)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public double Density(Matrix<double> x)
		{
			return 0.0;
		}

		public Matrix<double> Sample()
		{
			return null;
		}

		public static Matrix<double> Sample(System.Random rnd, double degreesOfFreedom, Matrix<double> scale)
		{
			return null;
		}

		private static Matrix<double> DoSample(System.Random rnd, double degreesOfFreedom, Matrix<double> scale, Cholesky<double> chol)
		{
			return null;
		}
	}
}
