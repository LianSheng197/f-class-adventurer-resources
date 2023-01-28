namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class DenseLU : LU
	{
		public static DenseLU Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseLU(Matrix<MathNet.Numerics.Complex32> factors, int[] pivots)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}

		public override Matrix<MathNet.Numerics.Complex32> Inverse()
		{
			return null;
		}
	}
}
