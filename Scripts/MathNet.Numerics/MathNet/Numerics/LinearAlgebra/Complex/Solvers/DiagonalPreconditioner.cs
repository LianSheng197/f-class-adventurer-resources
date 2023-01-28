using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class DiagonalPreconditioner : IPreconditioner<System.Numerics.Complex>
	{
		private System.Numerics.Complex[] _inverseDiagonals;

		internal DiagonalMatrix DiagonalEntries()
		{
			return null;
		}

		public void Initialize(Matrix<System.Numerics.Complex> matrix)
		{
		}

		public void Approximate(Vector<System.Numerics.Complex> rhs, Vector<System.Numerics.Complex> lhs)
		{
		}
	}
}
