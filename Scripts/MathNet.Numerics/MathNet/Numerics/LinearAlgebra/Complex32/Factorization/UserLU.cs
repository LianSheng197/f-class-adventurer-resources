namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class UserLU : LU
	{
		public static UserLU Create(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		private UserLU(Matrix<MathNet.Numerics.Complex32> factors, int[] pivots)
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
