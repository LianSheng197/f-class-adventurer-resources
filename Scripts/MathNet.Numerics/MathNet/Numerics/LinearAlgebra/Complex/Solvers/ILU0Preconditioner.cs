using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class ILU0Preconditioner : IPreconditioner<System.Numerics.Complex>
	{
		private SparseMatrix _decompositionLU;

		internal Matrix<System.Numerics.Complex> UpperTriangle()
		{
			return null;
		}

		internal Matrix<System.Numerics.Complex> LowerTriangle()
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
