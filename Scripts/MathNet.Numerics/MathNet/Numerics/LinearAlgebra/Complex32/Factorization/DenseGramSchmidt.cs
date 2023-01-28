namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class DenseGramSchmidt : GramSchmidt
	{
		public static DenseGramSchmidt Create(Matrix<MathNet.Numerics.Complex32> matrix)
		{
			return null;
		}

		private DenseGramSchmidt(Matrix<MathNet.Numerics.Complex32> q, Matrix<MathNet.Numerics.Complex32> rFull)
			: base(null, null)
		{
		}

		private static void Factorize(MathNet.Numerics.Complex32[] q, int rowsQ, int columnsQ, MathNet.Numerics.Complex32[] r)
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
