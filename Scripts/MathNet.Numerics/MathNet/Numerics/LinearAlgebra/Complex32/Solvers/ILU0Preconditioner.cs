using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Solvers
{
	public sealed class ILU0Preconditioner : IPreconditioner<MathNet.Numerics.Complex32>
	{
		private SparseMatrix _decompositionLU;

		internal Matrix<MathNet.Numerics.Complex32> UpperTriangle()
		{
			return null;
		}

		internal Matrix<MathNet.Numerics.Complex32> LowerTriangle()
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
