namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class UserLU : LU
	{
		public static UserLU Create(Matrix<double> matrix)
		{
			return null;
		}

		private UserLU(Matrix<double> factors, int[] pivots)
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
