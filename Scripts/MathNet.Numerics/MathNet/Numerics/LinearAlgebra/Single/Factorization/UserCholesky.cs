namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class UserCholesky : Cholesky
	{
		private static void DoCholesky(Matrix<float> factor)
		{
		}

		public static UserCholesky Create(Matrix<float> matrix)
		{
			return null;
		}

		public override void Factorize(Matrix<float> matrix)
		{
		}

		private UserCholesky(Matrix<float> factor)
			: base(null)
		{
		}

		private static void DoCholeskyStep(Matrix<float> data, int rowDim, int firstCol, int colLimit, float[] multipliers, int availableCores)
		{
		}

		public override void Solve(Matrix<float> input, Matrix<float> result)
		{
		}

		public override void Solve(Vector<float> input, Vector<float> result)
		{
		}
	}
}
