namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class UserCholesky : Cholesky
	{
		private static void DoCholesky(Matrix<double> factor)
		{
		}

		public static UserCholesky Create(Matrix<double> matrix)
		{
			return null;
		}

		public override void Factorize(Matrix<double> matrix)
		{
		}

		private UserCholesky(Matrix<double> factor)
			: base(null)
		{
		}

		private static void DoCholeskyStep(Matrix<double> data, int rowDim, int firstCol, int colLimit, double[] multipliers, int availableCores)
		{
		}

		public override void Solve(Matrix<double> input, Matrix<double> result)
		{
		}

		public override void Solve(Vector<double> input, Vector<double> result)
		{
		}
	}
}
