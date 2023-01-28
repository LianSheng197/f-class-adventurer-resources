namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class DenseCholesky : Cholesky
	{
		public static DenseCholesky Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseCholesky(Matrix<float> factor)
			: base(null)
		{
		}

		public override void Solve(Matrix<float> input, Matrix<float> result)
		{
		}

		public override void Solve(Vector<float> input, Vector<float> result)
		{
		}

		public override void Factorize(Matrix<float> matrix)
		{
		}
	}
}
