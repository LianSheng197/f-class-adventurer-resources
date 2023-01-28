using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.Distributions
{
	public class InverseWishart : IDistribution
	{
		private System.Random _random;

		private readonly double _freedom;

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

		public InverseWishart(double degreesOfFreedom, Matrix<double> scale)
		{
		}

		public InverseWishart(double degreesOfFreedom, Matrix<double> scale, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(double degreesOfFreedom, Matrix<double> scale)
		{
			return false;
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
	}
}
