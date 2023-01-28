namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class DenseLU : LU
	{
		public static DenseLU Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseLU(Matrix<float> factors, int[] pivots)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<float> input, Matrix<float> result)
		{
		}

		public override void Solve(Vector<float> input, Vector<float> result)
		{
		}

		public override Matrix<float> Inverse()
		{
			return null;
		}
	}
}
