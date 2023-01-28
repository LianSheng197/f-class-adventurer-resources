using System;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Distributions
{
	public class MatrixNormal : IDistribution
	{
		private System.Random _random;

		private readonly Matrix<double> _m;

		private readonly Matrix<double> _v;

		private readonly Matrix<double> _k;

		public Matrix<double> Mean => null;

		public Matrix<double> RowCovariance => null;

		public Matrix<double> ColumnCovariance => null;

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

		public MatrixNormal(Matrix<double> m, Matrix<double> v, Matrix<double> k)
		{
		}

		public MatrixNormal(Matrix<double> m, Matrix<double> v, Matrix<double> k, System.Random randomSource)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsValidParameterSet(Matrix<double> m, Matrix<double> v, Matrix<double> k)
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

		public static Matrix<double> Sample(System.Random rnd, Matrix<double> m, Matrix<double> v, Matrix<double> k)
		{
			return null;
		}

		private static Vector<double> SampleVectorNormal(System.Random rnd, Vector<double> mean, Matrix<double> covariance)
		{
			return null;
		}
	}
}
