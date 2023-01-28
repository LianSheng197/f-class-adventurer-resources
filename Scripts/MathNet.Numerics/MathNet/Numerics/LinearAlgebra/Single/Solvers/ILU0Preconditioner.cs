using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Single.Solvers
{
	public sealed class ILU0Preconditioner : IPreconditioner<float>
	{
		private SparseMatrix _decompositionLU;

		internal Matrix<float> UpperTriangle()
		{
			return null;
		}

		internal Matrix<float> LowerTriangle()
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
