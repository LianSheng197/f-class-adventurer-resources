namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class DenseGramSchmidt : GramSchmidt
	{
		public static DenseGramSchmidt Create(Matrix<float> matrix)
		{
			return null;
		}

		private DenseGramSchmidt(Matrix<float> q, Matrix<float> rFull)
			: base(null, null)
		{
		}

		private static void Factorize(float[] q, int rowsQ, int columnsQ, float[] r)
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
