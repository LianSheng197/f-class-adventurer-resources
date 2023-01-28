using MathNet.Numerics.LinearAlgebra.Solvers;

namespace MathNet.Numerics.LinearAlgebra.Double.Solvers
{
	public sealed class TFQMR : IIterativeSolver<double>
	{
		private static void CalculateTrueResidual(Matrix<double> matrix, Vector<double> residual, Vector<double> x, Vector<double> b)
		{
		}

		private static bool IsEven(int number)
		{
			return false;
		}

		public void Solve(Matrix<double> matrix, Vector<double> input, Vector<double> result, Iterator<double> iterator, IPreconditioner<double> preconditioner)
		{
		}
	}
}
