using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class UserCholesky : Cholesky
	{
		private static void DoCholesky(Matrix<System.Numerics.Complex> factor)
		{
		}

		public static UserCholesky Create(Matrix<System.Numerics.Complex> matrix)
		{
			return null;
		}

		public override void Factorize(Matrix<System.Numerics.Complex> matrix)
		{
		}

		private UserCholesky(Matrix<System.Numerics.Complex> factor)
			: base(null)
		{
		}

		private static void DoCholeskyStep(Matrix<System.Numerics.Complex> data, int rowDim, int firstCol, int colLimit, System.Numerics.Complex[] multipliers, int availableCores)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}
	}
}
