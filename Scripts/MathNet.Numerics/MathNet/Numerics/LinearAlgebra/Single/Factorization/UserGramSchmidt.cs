namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class UserGramSchmidt : GramSchmidt
	{
		public static UserGramSchmidt Create(Matrix<float> matrix)
		{
			return null;
		}

		private UserGramSchmidt(Matrix<float> q, Matrix<float> rFull)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<float> input, Matrix<float> result)
		{
		}

		public override void Solve(Vector<float> input, Vector<float> result)
		{
		}
	}
}
