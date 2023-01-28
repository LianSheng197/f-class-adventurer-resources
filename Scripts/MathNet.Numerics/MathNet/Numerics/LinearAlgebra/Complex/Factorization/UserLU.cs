using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class UserLU : LU
	{
		public static UserLU Create(Matrix<System.Numerics.Complex> matrix)
		{
			return null;
		}

		private UserLU(Matrix<System.Numerics.Complex> factors, int[] pivots)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> Inverse()
		{
			return null;
		}
	}
}
