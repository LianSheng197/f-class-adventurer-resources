namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class UserCholesky : Cholesky
	{
		private static void DoCholesky(Matrix<MathNet.Numerics.Complex32> factor)
		{
		}

		public static UserCholesky Create(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		public override void Factorize(Matrix<MathNet.Numerics.Complex32> matrix)
		{
		}

		private UserCholesky(Matrix<MathNet.Numerics.Complex32> factor)
			: base(null)
		{
		}

		private static void DoCholeskyStep(Matrix<MathNet.Numerics.Complex32> data, int rowDim, int firstCol, int colLimit, MathNet.Numerics.Complex32[] multipliers, int availableCores)
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}
	}
}
