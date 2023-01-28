namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class UserGramSchmidt : GramSchmidt
	{
		public static UserGramSchmidt Create(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		private UserGramSchmidt(Matrix<MathNet.Numerics.Complex32> q, Matrix<MathNet.Numerics.Complex32> rFull)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}
	}
}
