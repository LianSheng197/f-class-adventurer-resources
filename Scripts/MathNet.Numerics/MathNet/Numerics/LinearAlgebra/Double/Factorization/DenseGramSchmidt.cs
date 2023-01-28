namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class DenseGramSchmidt : GramSchmidt
	{
		public static DenseGramSchmidt Create(Matrix<double> matrix)
		{
			return null;
		}

		private DenseGramSchmidt(Matrix<double> q, Matrix<double> rFull)
			: base(null, null)
		{
		}

		private static void Factorize(double[] q, int rowsQ, int columnsQ, double[] r)
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
