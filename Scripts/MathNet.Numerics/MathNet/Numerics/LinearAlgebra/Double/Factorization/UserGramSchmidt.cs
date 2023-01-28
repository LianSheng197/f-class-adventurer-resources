namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class UserGramSchmidt : GramSchmidt
	{
		public static UserGramSchmidt Create(Matrix<double> matrix)
		{
			return null;
		}

		private UserGramSchmidt(Matrix<double> q, Matrix<double> rFull)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<double> input, Matrix<double> result)
		{
		}

		public override void Solve(Vector<double> input, Vector<double> result)
		{
		}
	}
}
