using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class DiagonalPreconditioner : IPreconditioner<double>
	{
		private double[] _inverseDiagonals;

		internal DiagonalMatrix DiagonalEntries()
		{
			return null;
		}

		public void Initialize(Matrix<double> matrix)
		{
		}

		public void Approximate(Vector<double> rhs, Vector<double> lhs)
		{
		}
	}
}
