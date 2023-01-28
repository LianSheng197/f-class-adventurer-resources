using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class DiagonalPreconditioner : IPreconditioner<float>
	{
		private float[] _inverseDiagonals;

		internal DiagonalMatrix DiagonalEntries()
		{
			return null;
		}

		public void Initialize(Matrix<float> matrix)
		{
		}

		public void Approximate(Vector<float> rhs, Vector<float> lhs)
		{
		}
	}
}
