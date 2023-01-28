using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class DiagonalPreconditioner : IPreconditioner<MathNet.Numerics.Complex32>
	{
		private MathNet.Numerics.Complex32[] _inverseDiagonals;

		internal DiagonalMatrix DiagonalEntries()
		{
			return null;
		}

		public void Initialize(Matrix<MathNet.Numerics.Complex32> matrix)
		{
		}

		public void Approximate(Vector<MathNet.Numerics.Complex32> rhs, Vector<MathNet.Numerics.Complex32> lhs)
		{
		}
	}
}
