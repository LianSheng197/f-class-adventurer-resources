namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class DenseCholesky : Cholesky
	{
		public static DenseCholesky Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseCholesky(Matrix<double> factor)
			: base(null)
		{
		}

		public override void Solve(Matrix<double> input, Matrix<double> result)
		{
		}

		public override void Solve(Vector<double> input, Vector<double> result)
		{
		}

		public override void Factorize(Matrix<double> matrix)
		{
		}
	}
}
