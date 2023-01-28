using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class DenseCholesky : Cholesky
	{
		public static DenseCholesky Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseCholesky(Matrix<System.Numerics.Complex> factor)
			: base(null)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}

		public override void Factorize(Matrix<System.Numerics.Complex> matrix)
		{
		}
	}
}
