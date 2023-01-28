using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class BiCgStab : IIterativeSolver<double>
	{
		private static void CalculateTrueResidual(Matrix<double> matrix, Vector<double> residual, Vector<double> x, Vector<double> b)
		{
		}

		public void Solve(Matrix<double> matrix, Vector<double> input, Vector<double> result, Iterator<double> iterator, IPreconditioner<double> preconditioner)
		{
		}
	}
}
