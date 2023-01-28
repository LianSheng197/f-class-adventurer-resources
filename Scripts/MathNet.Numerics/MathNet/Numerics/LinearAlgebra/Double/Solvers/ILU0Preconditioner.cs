using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class ILU0Preconditioner : IPreconditioner<double>
	{
		private SparseMatrix _decompositionLU;

		internal Matrix<double> UpperTriangle()
		{
			return null;
		}

		internal Matrix<double> LowerTriangle()
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
