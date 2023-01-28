using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class DenseGramSchmidt : GramSchmidt
	{
		public static DenseGramSchmidt Create(Matrix<System.Numerics.Complex> matrix)
		{
			return null;
		}

		private DenseGramSchmidt(Matrix<System.Numerics.Complex> q, Matrix<System.Numerics.Complex> rFull)
			: base(null, null)
		{
		}

		private static void Factorize(System.Numerics.Complex[] q, int rowsQ, int columnsQ, System.Numerics.Complex[] r)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}
	}
}
