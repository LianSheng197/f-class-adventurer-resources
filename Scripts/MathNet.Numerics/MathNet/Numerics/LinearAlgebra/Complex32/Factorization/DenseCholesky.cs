namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class DenseCholesky : Cholesky
	{
		public static DenseCholesky Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseCholesky(Matrix<MathNet.Numerics.Complex32> factor)
			: base(null)
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Factorize(Matrix<MathNet.Numerics.Complex32> matrix)
		{
		}
	}
}
