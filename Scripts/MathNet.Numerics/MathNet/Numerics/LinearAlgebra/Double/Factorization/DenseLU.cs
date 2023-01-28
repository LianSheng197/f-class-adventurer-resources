namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class DenseLU : LU
	{
		public static DenseLU Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseLU(Matrix<double> factors, int[] pivots)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<double> input, Matrix<double> result)
		{
		}

		public override void Solve(Vector<double> input, Vector<double> result)
		{
		}

		public override Matrix<double> Inverse()
		{
			return null;
		}
	}
}
