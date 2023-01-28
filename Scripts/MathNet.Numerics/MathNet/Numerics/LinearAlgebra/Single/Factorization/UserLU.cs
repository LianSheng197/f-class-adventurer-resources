namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class UserLU : LU
	{
		public static UserLU Create(Matrix<float> matrix)
		{
			return null;
		}

		private UserLU(Matrix<float> factors, int[] pivots)
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
