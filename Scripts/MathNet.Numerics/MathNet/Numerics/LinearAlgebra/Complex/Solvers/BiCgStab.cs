using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Complex.Solvers
{
	public sealed class BiCgStab : IIterativeSolver<System.Numerics.Complex>
	{
		private static void CalculateTrueResidual(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> residual, Vector<System.Numerics.Complex> x, Vector<System.Numerics.Complex> b)
		{
		}

		public void Solve(Matrix<System.Numerics.Complex> matrix, Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result, Iterator<System.Numerics.Complex> iterator, IPreconditioner<System.Numerics.Complex> preconditioner)
		{
		}
	}
}
